// ---------------------------------------------------------------------------
#include <conio.h>
#include <string.h>
#include <vcl.h>
#pragma hdrstop

#include "form.h"
#include "num_stack.h"
#include "oper_stack.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
NumStack numbers;
OperStack operands;

// ---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner) : TForm(Owner) {
}
// ---------------------------------------------------------------------------

void __fastcall TForm1::Edit1KeyPress(TObject *Sender, System::WideChar &Key) {
	static bool dot_isput;
	char ch = (char)Key;
	if (ch == ' ' || ch == '\b' || (ch >= 'a' && ch <= 'e') ||
		(ch >= '(' && ch <= '-') || (ch >= '/' && ch <= '9')) {
		if (ch == ',') {

			if (!dot_isput && Edit1->GetTextLen() > 0) {
				if (isdigit(Edit1->Text[Edit1->GetTextLen()])) {
					dot_isput = true;
					return;
				}
			}

			Key = NULL;
		}

		else if ((dot_isput && ch == ' ') || (Edit1->GetTextLen() >
			0 && Edit1->Text[Edit1->GetTextLen()] == ',' && ch == '\b'))
		{
			dot_isput = false;
		}
	}
	else
		Key = NULL;
}
// ---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender) {
	Edit7->Clear();
    Edit8->Clear();
	AnsiString expression = Edit1->Text;
	short oper_counter = 0, num_counter = 0;
	AnsiString rpn;

	//analysing expression for correct input, retlanslating exp to RPN, forming stacks
	for (int i = 1; i <= Edit1->GetTextLen(); i++) {

		if (expression[i] == ' ')
			continue;

		else if (!isdigit(expression[i]) && !isalpha(expression[i]))
		{
			if (!operands.push(expression[i], rpn))
			{
				InputError();
				return;
			}

			if (expression[i] != '(' && expression[i] != ')') {
				oper_counter++;
			}
		}

		else if (isalpha(expression[i])) {
			num_counter++;
			rpn = rpn + expression[i] + ' ';
		}

		else if (isdigit(expression[i])) {
			while (i <= Edit1->GetTextLen() && (isdigit(expression[i]) || expression[i] == ',')){
				rpn = rpn + expression[i];
				i++;
			}
			i--;
			rpn = rpn + ' ';
			num_counter++;
		}
	}

	char ch = operands.pop();
	while(ch != '\0')
	{
		if (ch == '(' || ch == ')') {
			InputError();
			return;
		}
		rpn = rpn + ch + ' ';
		ch = operands.pop();
	}

	if (num_counter != oper_counter + 1) {
		InputError();
		return;
	}

	//counting the expression using RPN
	for (int i = 1; i <= rpn.Length(); i++) {
		if (rpn[i] == ' ')
			continue;

		else if (isalpha(rpn[i])) {
			double a = 0;
			switch (rpn[i]) {
			case 'a':
				a = StrToFloat(Edit2->Text);
				break;
			case 'b':
				a = StrToFloat(Edit3->Text);
				break;
			case 'c':
				a = StrToFloat(Edit4->Text);
				break;
			case 'd':
				a = StrToFloat(Edit5->Text);
				break;
			case 'e':
				a = StrToFloat(Edit6->Text);
				break;
			}
			numbers.push(a);
		}

		else if (isdigit(rpn[i])) {
			int k = i;
			while (k <= Edit1->GetTextLen() && isdigit(rpn[k]))
				k++;
			double a = 0;
			double digit = pow(10, k - i - 1);
			while (i <= Edit1->GetTextLen() && (isdigit(rpn[i]) || rpn[i] == ',')){
				if (rpn[i] == ',') {
						digit = 0.1;
					i++;
					continue;
				}

				a+= digit * (rpn[i] - 48);
				digit /= 10;
				i++;
			}
			i--;
			numbers.push(a);
		}

		else if (!isdigit(rpn[i]) && !isalpha(rpn[i]) && rpn[i] != ' ' && rpn[i] != ',') {
			try{
				numbers.count(rpn[i]);
			}

			catch(...){
				InputError();
				return;
			}
		}
	}
	Edit7->Text = rpn.c_str();
	Edit8->Text = numbers.get_result();
}
// ---------------------------------------------------------------------------
void __fastcall TForm1::Edit2KeyPress(TObject *Sender, System::WideChar &Key)
{
	EditsCheck(Edit2, Key);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Edit3KeyPress(TObject *Sender, System::WideChar &Key)
{
	EditsCheck(Edit3, Key);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Edit4KeyPress(TObject *Sender, System::WideChar &Key)
{
	EditsCheck(Edit4, Key);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Edit5KeyPress(TObject *Sender, System::WideChar &Key)
{
	EditsCheck(Edit5, Key);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Edit6KeyPress(TObject *Sender, System::WideChar &Key)
{
	EditsCheck(Edit6, Key);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::EditsCheck(TEdit *Edit, System::WideChar &Key)
{
	bool dot_isput;

	if (wcschr(Edit->Text.c_str(), ',') != NULL)
		dot_isput = true;
	else
		dot_isput = false;

	char ch = (char)Key;
	if (ch == '\b' || (ch >= '0' && ch <= '9') || ch == ',') {
		if (ch == ',') {

			if (!dot_isput && Edit->GetTextLen() > 0) {
				if (isdigit(Edit->Text[Edit->GetTextLen()])) {
					dot_isput = true;
					return;
				}
			}

			Key = NULL;
		}

		else if (Edit->GetTextLen() >
			0 && Edit->Text[Edit->GetTextLen()] == ',' && ch == '\b')
		{
			dot_isput = false;
		}
	}
	else
		Key = NULL;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::InputError()
{
	Edit2->Text = IntToStr(0);
	Edit3->Text = IntToStr(0);
	Edit4->Text = IntToStr(0);
	Edit5->Text = IntToStr(0);
	Edit6->Text = IntToStr(0);
	Edit7->Clear();
	numbers.free();
	operands.free();
	MessageDlg("Unable to count due to incorrect signs or numbers input!",
		mtError, mbOKCancel, 0);
	Edit1->Clear();
}
//---------------------------------------------------------------------------
