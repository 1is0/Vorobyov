//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Main.h"
#include "Queue.h"
#include "CustomQueue.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
queue q1;
custom_queue q2;
bool combined = false;

//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
	srand(time(0));
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
	ListBox1->Items->Add(IntToStr(q1.push()));
	if (combined) {
		int i = ListBox2->Items->Count + 1;
		ListBox2->Items->Clear();
		for (int k = 0; k < i; k++) {
			ListBox2->Items->Add(IntToStr(q2[k]));
		}
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button4Click(TObject *Sender)
{
	ListBox2->Items->Add(IntToStr(q2.push()));
	if (!combined)
		q2.search_max();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
	if (q2.get_head() == q1.get_head())
		q2.move_head();
	node* nd = q1.pop();
	if (nd)
		ListBox1->Items->Delete(0);

	if (combined) {
		q2.remove(nd);

		if (nd == nullptr){
			combined = false;
			return;
		}

		int i = ListBox2->Items->Count - 1;
		ListBox2->Items->Clear();
		for (int k = 0; k < i; k++)
			ListBox2->Items->Add(IntToStr(q2[k]));

		if (ListBox1->Items->Count == 0)
			combined = false;
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{

	if (combined && q2.get_head() == q1.get_head()){
		q1.move_head();
		q2.pop();
		ListBox1->Items->Delete(0);
		ListBox2->Items->Delete(0);
		if (q1.get_head() == nullptr && q1.get_tail() == nullptr)
				combined = false;
		return;
	}

	if (q2.pop())
	{
		ListBox2->Items->Delete(0);
		if (!combined)
			q2.search_max();
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button5Click(TObject *Sender)
{
	q2.task_pop(q1);
	int i = ListBox2->Items->Count + ListBox1->Items->Count;
	ListBox2->Items->Clear();
	for (int k = 0; k < i; k++) {
		ListBox2->Items->Add(IntToStr(q2[k]));
	}
	Button5->Enabled = false;
	combined = true;
}
//---------------------------------------------------------------------------

