//---------------------------------------------------------------------------
#pragma once
#ifndef HashH
#define HashH
#include "Stack.h"
#include <vcl.h>
//---------------------------------------------------------------------------
#endif

class Hash{
private:
	Stack** hash_arr;
	int hash_size;
	int hash_func(int _key);
public:
	Hash(int _size);
	bool add(int _key);
	bool del(int _key);
	void del_hash();
	bool find(int _key);
	void pop_even();
    void display(TMemo* Memo);
};
