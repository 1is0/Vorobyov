//---------------------------------------------------------------------------
#pragma once
#ifndef DataH
#define DataH
#include <vcl.h>
//---------------------------------------------------------------------------
#endif

class Data {
public:
	AnsiString name;
	int num;
	Data* left;
	Data* right;

	Data(AnsiString t, int k);
};