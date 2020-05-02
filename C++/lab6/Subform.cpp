// ---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Subform.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"

TForm2 *Form2;
extern short f2_trigger; // for specific view of Form2
extern CustomTree* tree;

// ---------------------------------------------------------------------------
__fastcall TForm2::TForm2(TComponent* Owner) : TForm(Owner) {
}

// ---------------------------------------------------------------------------
void __fastcall TForm2::Button1Click(TObject *Sender) {
	switch (f2_trigger) {
	case 1: {
			if (!tree->add_item(tree->get_root(), Edit2->Text,
				StrToInt(Edit1->Text))) {
				MessageDlg(
					"Unable to insert node due to repeating passport name!",
					mtWarning, TMsgDlgButtons() << mbOK, 0);
			}

			else{
                MessageDlg("Successfully added node!", mtInformation,
				TMsgDlgButtons() << mbOK, 0);
			}
			break;
		}
	case 2: {
			Data * nd = tree->find(*tree->get_root(), StrToInt(Edit1->Text));
			if (nd) {
				AnsiString msg = AnsiString("Match found!\nName: ") + nd->name +
					AnsiString("\nPassport number: ") + IntToStr(nd->num);
				ShowMessage(msg);
			}
			else
				MessageDlg("No match found.", mtInformation,
				TMsgDlgButtons() << mbOK, 0);
			break;
		}
	case 3: {
			if (tree->delete_item(tree->get_root(), StrToInt(Edit1->Text)))
				MessageDlg("Successfully deleted node!", mtInformation,
				TMsgDlgButtons() << mbOK, 0);
			else
				MessageDlg("Person not found.", mtInformation,
				TMsgDlgButtons() << mbOK, 0);
			break;
		}
	}
	Form2->Close();
}
// ---------------------------------------------------------------------------
void __fastcall TForm2::FormShow(TObject *Sender)
{
    switch (f2_trigger) {
	case 1:
		Label3->Caption = "Add";
		break;
	case 2:
		Label3->Caption = "Find";
		break;
	case 3:
		Label3->Caption = "Delete";
		break;
	}

	if (f2_trigger != 1) {
		Label2->Visible = false;
		Edit2->Visible = false;
	}

	else {
		Label2->Visible = true;
		Edit2->Visible = true;
	}
}
//---------------------------------------------------------------------------

