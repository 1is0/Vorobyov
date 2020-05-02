// ---------------------------------------------------------------------------
#pragma once
#ifndef TreeH
#define TreeH
#include "Data.h"
#include <vcl.h>
// ---------------------------------------------------------------------------
#endif

class Tree {
protected:
	Data* root;
	int size;

	void fill_arr(Data** root, Data** mass, int &i);
	void form_new_tree(Data** root, Data** mass, int sizeofmass);
	void central_el(Data** root, Data** mass, int sizeofmass,
		int startposition);

public:
	Tree();

	Data** get_root();
	int get_size();

    Data* find(Data* root, int num);
	bool add_item(Data** root, AnsiString name, int num);
	void print_inorder(Data* root, TMemo *Memo);
	void print_postorder(Data* root, TMemo *Memo);
	void print_preorder(Data* root, TMemo *Memo);
	void balance(Data** root);
	bool delete_item(Data** root, int num);
	void delete_tree(Data** root);
};
