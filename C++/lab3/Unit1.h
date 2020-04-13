// ---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
// ---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.ComCtrls.hpp>
#include <System.ImageList.hpp>
#include <Vcl.ImgList.hpp>
#include <Vcl.ExtCtrls.hpp>
#include <Vcl.Mask.hpp>

// ---------------------------------------------------------------------------
class TForm1 : public TForm {
__published: // IDE-managed Components
	TListView *ListView1;
	TImageList *ImageList1;
	TEdit *Edit1;
	TLabel *Label1;
	TPanel *Panel1;
	TLabel *Label2;
	TEdit *Edit2;
	TLabel *Label3;
	TLabel *Label4;
	TCheckBox *CheckBox1;
	TComboBox *ComboBox1;
	TLabel *Label5;
	TPanel *Panel2;
	TLabel *Label6;
	TEdit *Edit3;
	TLabel *Label7;
	TPanel *Panel3;
	TButton *Button1;
	TButton *Button2;
	TPanel *Panel5;
	TLabel *Label13;
	TRadioGroup *RadioGroup1;
	TButton *Button3;
	TDateTimePicker *DateTimePicker1;
	TComboBox *ComboBox3;

	void __fastcall Button1Click(TObject *Sender);
	void __fastcall Button2Click(TObject *Sender);
	void __fastcall ListView1Click(TObject *Sender);
	void __fastcall Button3Click(TObject *Sender);
	void __fastcall ClearPads();
	void __fastcall Edit3KeyPress(TObject *Sender, System::WideChar &Key);
	void __fastcall RadioGroup1Click(TObject *Sender);
	void __fastcall AddListItem(AnsiString gr, AnsiString mrk, AnsiString tckt,
		AnsiString dt, bool st);
	void __fastcall ComboBox3Change(TObject *Sender);
		private : // User declarations
		public : // User declarations
		__fastcall TForm1(TComponent* Owner);
};

// ---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
// ---------------------------------------------------------------------------
#endif
