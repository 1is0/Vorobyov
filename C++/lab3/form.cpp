// ---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop
#include "list.h"
#include "form.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
List list;
AnsiString old_ticket;
int prevItemIndex = 0;

// ---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner) : TForm(Owner) {
}

// ---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender) {
	bool st;
	if (CheckBox1->Checked)
		st = true;
	else
		st = false;
	int i;
	for (i = 0; i < list.get_size(); i++) {
		if (list[i]->ticket_num == Edit1->Text) {
			break;
		}
	}

	if (ComboBox1->ItemIndex != -1 && Edit2->Text != "" && Edit1->Text != "" &&
		i == list.get_size()) {
		AnsiString combo = ComboBox1->Items->Strings[ComboBox1->ItemIndex];
		AnsiString e2 = Edit2->Text;
		AnsiString e1 = Edit1->Text;
		AnsiString me1 = DateTimePicker1->Date.FormatString("dd.MM.yyyy");
		list.push_head(combo, e2, e1, me1, st);
		TListItem* new_item = ListView1->Items->Add();
		new_item->GroupID = ComboBox1->ItemIndex;
		new_item->Caption = Edit1->Text;
		new_item->SubItems->Add(Edit2->Text);
		new_item->SubItems->Add(DateTimePicker1->Date.FormatString
			("dd.MM.yyyy"));
		if (st)
			new_item->SubItems->Add("Ready");
		else
			new_item->SubItems->Add("Not ready");
		ClearPads();
	}
	else if (i != list.get_size())
		MessageDlg("Such a ticket number already exists!", mtError,
		mbOKCancel, 0);
	else
		MessageDlg("Wrong data input, re-enter!", mtError, mbOKCancel, 0);
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::Button2Click(TObject *Sender) {
	bool st;
	if (CheckBox1->Checked)
		st = true;
	else
		st = false;
	int i;
	for (i = 0; i < list.get_size(); i++) {
		if (list[i]->ticket_num == Edit1->Text && list.find_node(old_ticket)
			!= list[i]) {
			break;
		}
	}

	if (ComboBox1->ItemIndex != -1 && Edit2->Text != "" && Edit1->Text != "" &&
		i == list.get_size()) {
		AnsiString combo = ComboBox1->Items->Strings[ComboBox1->ItemIndex];
		AnsiString e2 = Edit2->Text;
		AnsiString e1 = Edit1->Text;
		AnsiString me1 = DateTimePicker1->Date.FormatString("dd.MM.yyyy");
		list.edit_node(combo, e2, e1, me1, st, list.find_node(old_ticket));
		ListView1->Selected->Caption = e1;
		ListView1->Selected->GroupID = ComboBox1->ItemIndex;
		ListView1->Selected->SubItems->Strings[0] = e2;
		ListView1->Selected->SubItems->Strings[1] =
			DateTimePicker1->Date.FormatString("dd.MM.yyyy");
		if (st)
			ListView1->Selected->SubItems->Strings[2] = "Ready";
		else
			ListView1->Selected->SubItems->Strings[2] = "Not ready";
		old_ticket = e1;
		ClearPads();
	}
	else if (i != list.get_size())
		MessageDlg("Such a ticket number already exists!", mtError,
		mbOKCancel, 0);
	else
		MessageDlg("Wrong data input, re-enter!", mtError, mbOKCancel, 0);
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::ListView1Click(TObject *Sender) {
	if (ListView1->Selected != NULL) {
		bool st;
		AnsiString combo, e2, e1, me1;
		list.get_node(combo, e2, e1, me1, st,
			list.find_node(ListView1->Selected->Caption));
		if (st)
			CheckBox1->Checked = true;
		else
			CheckBox1->Checked = false;
		Edit2->Text = e2;
		Edit1->Text = e1;
		old_ticket = e1;
		DateTimePicker1->Date = StrToDate(me1);
		ComboBox1->Text = combo;
		Button2->Enabled = true;
		Button3->Enabled = true;
	}

	else {
		ClearPads();
	}
}
// ---------------------------------------------------------------------------

void __fastcall TForm1::Button3Click(TObject *Sender) {

	list.pop_out(old_ticket);
	ListView1->Selected->Delete();
	ClearPads();
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::ClearPads() {

	Button2->Enabled = false;
	Button3->Enabled = false;
	CheckBox1->Checked = false;
	DateTimePicker1->Date = Date();
	ComboBox1->Text = "";
	Edit2->Text = "";
	Edit1->Text = "";
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::Edit3KeyPress(TObject *Sender, System::WideChar &Key) {
	if (Key == VK_RETURN) {
		Application->Title = "Search result";
		if (!list.find_node(Edit3->Text))
			ShowMessage("No such ticket found");
		else {
			AnsiString gr, mrk, tckt, dt, stt;
			bool st;
			list.get_node(gr, mrk, tckt, dt, st, list.find_node(Edit3->Text));
			if (st)
				stt = "Ready";
			else
				stt = "Not ready";
			ShowMessage((AnsiString)"Ticket found!" + "\n -Ticket number: " +
				tckt + "\n -Item name: " + mrk + "\n -Group : " + gr +
				"\n -Date of reception: " + dt + "\n -State: " + stt);
		}
	}
}
// ---------------------------------------------------------------------------

void __fastcall TForm1::RadioGroup1Click(TObject *Sender) {
	if (RadioGroup1->ItemIndex != prevItemIndex) {
		ListView1->Clear();
		int size = list.get_size();
		AnsiString gr, mrk, tckt, dt;
		bool st;
		prevItemIndex = RadioGroup1->ItemIndex;
		switch (RadioGroup1->ItemIndex) {
		case 0: {
				for (int i = 0; i < size; i++) {
					list.get_node(gr, mrk, tckt, dt, st, list[i]);
					AddListItem(gr, mrk, tckt, dt, st);
				}
				break;
			}

		case 1: {
				for (int i = 0; i < size; i++) {
					list.get_node(gr, mrk, tckt, dt, st, list[i]);
					if (!st) {
						continue;
					}
					AddListItem(gr, mrk, tckt, dt, st);
				}
				break;
			}
		case 2: // not ready
			for (int i = 0; i < size; i++) {
				list.get_node(gr, mrk, tckt, dt, st, list[i]);
				if (st) {
					continue;
				}
				AddListItem(gr, mrk, tckt, dt, st);
			}
			break;
		case 3: // category
			if (ComboBox3->ItemIndex == -1) {
				MessageDlg("Enter the category!", mtError, mbOKCancel, 0);
			}
			else {
				AnsiString srchgr = ComboBox3->Text;
				for (int i = 0; i < size; i++) {
					list.get_node(gr, mrk, tckt, dt, st, list[i]);
					if (gr != srchgr) {
						continue;
					}
					AddListItem(gr, mrk, tckt, dt, st);
				}
			}
			break;
		}
	}
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::AddListItem(AnsiString gr, AnsiString mrk,
	AnsiString tckt, AnsiString dt, bool st) {
	TListItem* new_item = ListView1->Items->Add();
	ComboBox3->ItemIndex = -1;
	while (ComboBox3->Items->Strings[ComboBox3->ItemIndex] != gr)
		ComboBox3->ItemIndex++;
	new_item->GroupID = ComboBox3->ItemIndex;
	new_item->Caption = tckt;
	new_item->SubItems->Add(mrk);
	new_item->SubItems->Add(dt);
	if (st)
		new_item->SubItems->Add("Ready");
	else
		new_item->SubItems->Add("Not ready");
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::ComboBox3Change(TObject *Sender) {
	if (RadioGroup1->ItemIndex == 3) {
		if (ComboBox3->ItemIndex >= 0 && ComboBox3->ItemIndex < 18) {
			ListView1->Clear();
			int size = list.get_size();
			AnsiString gr, mrk, tckt, dt;
			bool st;
			AnsiString srchgr = ComboBox3->Text;
			for (int i = 0; i < size; i++) {
				list.get_node(gr, mrk, tckt, dt, st, list[i]);
				if (gr != srchgr) {
					continue;
				}
				AddListItem(gr, mrk, tckt, dt, st);
			}
		}
	}
}
// ---------------------------------------------------------------------------
