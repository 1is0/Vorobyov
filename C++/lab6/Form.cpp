//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Form.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"

TForm1 *Form1;
short f2_trigger;  //for specific functions and view of Subform
CustomTree* tree = new CustomTree();
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
	StringGrid1->Cells[0][0] = "(INT) Passport number";
	StringGrid1->Cells[1][0] = "(STRING) Full name";
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
	try{
		if(!tree->add_table(StringGrid1, tree->get_root()))
		MessageDlg("Not all fields can be inserted due to repeating passport name!",
			mtWarning, TMsgDlgButtons() << mbOK, 0);
		RewindTree();
	}

	catch(...){
		MessageDlg("Wrong data in StringGrid! Unable to insert all fields!",
			mtError, TMsgDlgButtons() << mbOK, 0);
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
	tree->balance(tree->get_root());
	RewindTree();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RewindTree()
{
	TreeView1->Items->Clear();
	tree->show_tree(TreeView1, *tree->get_root(), -1);
	int leaves = 0;
	tree->count_leaves(*tree->get_root(), leaves);
	Edit1->Text = IntToStr(leaves);
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button6Click(TObject *Sender)
{
	Memo1->Clear();
	switch(ComboBox1->ItemIndex){
		case -1:
			MessageDlg("Choose a way to print tree nodes!",
				mtError, TMsgDlgButtons() << mbOK, 0);
			break;
		case 0:
			tree->print_preorder(*tree->get_root(), Memo1);
			break;
		case 1:
			tree->print_postorder(*tree->get_root(), Memo1);
			break;
		case 2:
			tree->print_inorder(*tree->get_root(), Memo1);
			break;
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button8Click(TObject *Sender)
{
	StringGrid1->RowCount++;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button7Click(TObject *Sender)
{
	if (StringGrid1->RowCount > 1) {
		StringGrid1->Cells[0][StringGrid1->RowCount - 1] = "";
		StringGrid1->Cells[1][StringGrid1->RowCount - 1] = "";
		StringGrid1->RowCount--;
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button3Click(TObject *Sender)
{
	f2_trigger = 1;
	Form2->ShowModal();
	RewindTree();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button4Click(TObject *Sender)
{
	f2_trigger = 2;
	Form2->ShowModal();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button5Click(TObject *Sender)
{
	f2_trigger = 3;
	Form2->ShowModal();
    RewindTree();
}
