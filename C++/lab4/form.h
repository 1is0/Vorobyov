//---------------------------------------------------------------------------

#ifndef formH
#define formH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TEdit *Edit1;
	TEdit *Edit2;
	TEdit *Edit3;
	TEdit *Edit4;
	TEdit *Edit5;
	TEdit *Edit6;
	TEdit *Edit7;
	TLabel *Label1;
	TLabel *Label2;
	TLabel *Label6;
	TButton *Button1;
	TLabel *Label3;
	TLabel *Label4;
	TLabel *Label5;
	TLabel *Label7;
	TEdit *Edit8;
	TLabel *Label8;
	void __fastcall Edit1KeyPress(TObject *Sender, System::WideChar &Key);
	void __fastcall Button1Click(TObject *Sender);
	void __fastcall Edit2KeyPress(TObject *Sender, System::WideChar &Key);
	void __fastcall Edit3KeyPress(TObject *Sender, System::WideChar &Key);
	void __fastcall Edit4KeyPress(TObject *Sender, System::WideChar &Key);
	void __fastcall Edit5KeyPress(TObject *Sender, System::WideChar &Key);
	void __fastcall Edit6KeyPress(TObject *Sender, System::WideChar &Key);
	void __fastcall EditsCheck(TEdit *Edit, System::WideChar &Key);
	void __fastcall InputError();
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
