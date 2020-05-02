//---------------------------------------------------------------------------
#pragma once
#ifndef CustomTreeH
#define CustomTreeH
#include "Tree.h"
#include <vcl.h>
#include <Grids.hpp>
//---------------------------------------------------------------------------
#endif

class CustomTree: public Tree {
public:
	void show_tree(TTreeView* TreeView, Data* root, int m);
	int count_leaves(Data* root, int &counter);
	bool add_table(TStringGrid* StringGrid, Data** root);
};
