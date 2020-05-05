// ---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Form.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
Hash *myHash;

// ---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner) : TForm(Owner) {
	srand(time(0));
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender) {
	int nums, size;

	nums = StrToInt(Edit4->Text);
	size = StrToInt(Edit1->Text);

	//любимый билдер выдавал ошибку при попытке обработать это исключение
    //через блок try-throw-catch, пришлось выкручиваться как смог :/
	if (nums == 0 || size == 0) {
		MessageDlg(
			"Wrong data (num of items or hash table size). Repeat the input!",
			mtError, TMsgDlgButtons() << mbOK, 0);
		Edit1->Text = "";
        Edit4->Text = "";
        return;
	}

	if (myHash) {
		myHash->del_hash();
	}

	myHash = new Hash(size);
	for (int i = 0; i < nums; i++) {
		myHash->add(rand());
	}
	myHash->display(Memo2);
}
// ---------------------------------------------------------------------------

void __fastcall TForm1::Edit2KeyPress(TObject *Sender, System::WideChar &Key)
{
	try{
		if (Key == VK_RETURN) {
			if(myHash->find(StrToInt(Edit2->Text)))
				ShowMessage("Node with such a key exists in hash-table.");
			else
				ShowMessage("No match found.");
			Edit2->Clear();
		}
	}

	catch(...){
		MessageDlg(
			"Fullfill the key to search for!",
			mtError, TMsgDlgButtons() << mbOK, 0);
	}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Edit3KeyPress(TObject *Sender, System::WideChar &Key)
{
    try{
		if (Key == VK_RETURN) {
			if(myHash->del(StrToInt(Edit3->Text)))
				ShowMessage("Node successfully deleted.");
			else
				ShowMessage("Node with such a key doesn't exist.");
            Edit3->Clear();
		}
        myHash->display(Memo2);
	}

	catch(...){
		MessageDlg(
			"Fullfill the key to search for!",
			mtError, TMsgDlgButtons() << mbOK, 0);
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
	myHash->pop_even();
	myHash->display(Memo2);
}
//---------------------------------------------------------------------------

