// ---------------------------------------------------------------------------

#pragma hdrstop

#include "Tree.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)

Tree::Tree() : root(nullptr), size(0) {
}

bool Tree::add_item(Data** root, AnsiString name, int num) {

	if (!(*root)) {
		size++;
		*root = new Data(name, num);
		return 1;
	}

	if ((*root)->num == num || num == -1) {
		return 0;
	}

	else if ((*root)->num > num) {
		return add_item(&((*root)->left), name, num);
	}

	else {
		return add_item(&((*root)->right), name, num);
	}

}

void Tree::print_inorder(Data* root, TMemo *Memo) {
	if (!root) {
		return;
	}

	print_inorder(root->left, Memo);
	Memo->Lines->Add(IntToStr(root->num) + " | " + root->name);
	print_inorder(root->right, Memo);
}

void Tree::print_preorder(Data* root, TMemo *Memo) {
	if (!root) {
		return;
	}

	Memo->Lines->Add(IntToStr(root->num) + " | " + root->name);
	print_preorder(root->left, Memo);
	print_preorder(root->right, Memo);
}

void Tree::print_postorder(Data* root, TMemo *Memo) {
	if (!root) {
		return;
	}

	print_postorder(root->left, Memo);
	print_postorder(root->right, Memo);
	Memo->Lines->Add(IntToStr(root->num) + " | " + root->name);
}

void Tree::balance(Data** root) {
	Data **arr = new Data*[this->size];
	int m = 0;
	fill_arr(root, arr, m); 			   //filling by value rising
	form_new_tree(root, arr, this->size);  //forming new tree
	for (int i = 0; i < m; i++) {
		delete(arr[i]);
	}
	delete [] arr;
}

void Tree::fill_arr(Data** root, Data** arr, int &i) {
	if (!(*root)) {
		return;
	}

	fill_arr(&(*root)->left, arr,  i);
	arr[i] = (*root);
	i++;
	fill_arr(&(*root)->right, arr,  i);
}

void Tree::form_new_tree(Data** root, Data** arr, int sizeofarr) {
	*root = nullptr;
    this->size = 0;
	central_el(root, arr, sizeofarr, 0);
	for (int i = 0; i < sizeofarr; i++) {
		add_item(root, arr[i]->name, arr[i]->num);
	}
}

void Tree::central_el(Data** root, Data** arr, int sizeofarr,
	int startposition) {
	if (sizeofarr < 3) {
		return;
	}
	add_item(root, arr[startposition + (sizeofarr / 2)]->name,
		arr[startposition + (sizeofarr / 2)]->num);

	//not to repeat add_item for spread elements
	arr[startposition + (sizeofarr / 2)]->num = -1;

	central_el(&((*root)->left), arr, sizeofarr / 2, startposition);
	central_el(&((*root)->right), arr, sizeofarr / 2,
		startposition + (sizeofarr / 2) + 1);
}

bool Tree::delete_item(Data** root, int num) {
	if (!(*root)) {
		return 0;
	}

	if ((*root)->num == num) {

		if (!(*root)->left && !(*root)->right) {
			delete(*root);
			*root = nullptr;
            size--;
		}

		else if (!(*root)->left) {
			**root = *((*root)->right);
			delete(*root)->right;
			(*root)->right = nullptr;
			size--;
		}

		else if (!(*root)->right) {
			**root = *((*root)->left);
			delete(*root)->left;
			(*root)->left = nullptr;
			size--;
		}

		else {
			Data* temp = (*root)->right;
			while (temp->left) {
				temp = temp->left;
			}
			(*root)->name = temp->name;
			(*root)->num = temp->num;
			delete_item(&temp, temp->num);
		}

		return 1;
	}

	else {

		if ((*root)->num > num) {
			return delete_item(&(*root)->left, num);
		}

		else {
			return delete_item(&(*root)->right, num);
		}
	}
}

Data* Tree::find(Data* root, int num) {
	if (!root) {
		return nullptr;
	}

	if (root->num == num) {
		return root;
	}

	if (root->num > num) {
		return find(root->left, num);
	}

	else{
		return find(root->right, num);
	}
}

void Tree::delete_tree(Data** root) {

	if (!(*root)) {
		return;
	}
	delete_tree(&(*root)->left);
	delete_tree(&(*root)->right);
	delete(*root);
	*root = nullptr;
	size = 0;
}

Data** Tree::get_root(){
	return &this->root;
}

int Tree::get_size(){
	return this->size;
}
