//---------------------------------------------------------------------------
#pragma once
#ifndef FormH
#define FormH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.ComCtrls.hpp>
#include <Vcl.Grids.hpp>
#include <Vcl.ExtCtrls.hpp>
#include "Subform.h"
#include "CustomTree.h"
#include "Tree.h"
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TTreeView *TreeView1;
	TStringGrid *StringGrid1;
	TPanel *Panel1;
	TPanel *Panel2;
	TLabel *Label1;
	TLabel *Label2;
	TLabel *Label3;
	TButton *Button2;
	TButton *Button1;
	TButton *Button3;
	TMemo *Memo1;
	TButton *Button4;
	TButton *Button5;
	TButton *Button6;
	TLabel *Label4;
	TComboBox *ComboBox1;
	TEdit *Edit1;
	TLabel *Label5;
	TButton *Button8;
	TButton *Button7;
	TLabel *Label6;
	void __fastcall Button1Click(TObject *Sender);
	void __fastcall Button2Click(TObject *Sender);
    void __fastcall RewindTree();
	void __fastcall Button6Click(TObject *Sender);
	void __fastcall Button8Click(TObject *Sender);
	void __fastcall Button7Click(TObject *Sender);
	void __fastcall Button3Click(TObject *Sender);
	void __fastcall Button4Click(TObject *Sender);
	void __fastcall Button5Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
