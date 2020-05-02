//---------------------------------------------------------------------------

#pragma hdrstop

#include "CustomTree.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)

void CustomTree::show_tree(TTreeView* TreeView, Data* root, int m){
	if (!root) {
		return;
	}

	AnsiString str = IntToStr(root->num) + " | " + root->name;

	if (m == -1) {
		TreeView->Items->AddFirst(NULL, str);
	}

	else{
		TreeView->Items->AddChildFirst(TreeView->Items->Item[m], str);
	}

	m++;
	show_tree(TreeView, root->left, m);
	show_tree(TreeView, root->right, m);
	m--;
}

int CustomTree::count_leaves(Data* root, int &counter){
	if (!root) {
		return counter;
	}

	if (!root->left && !root->right) {
		counter++;
	}

	else {
		if (root->right) {
			count_leaves(root->right, counter);
		}

		if (root->left) {
			count_leaves(root->left, counter);
		}
	}

	return counter;
}

bool CustomTree::add_table(TStringGrid* StringGrid, Data** root){
	bool all_inserted = true;
	for (int i = 1; i < StringGrid->RowCount; i++) {
		if(!this->add_item(root, StringGrid->Cells[1][i],
			StrToInt(StringGrid->Cells[0][i])))
			all_inserted = false;
	}
	return all_inserted;
}

