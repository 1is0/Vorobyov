// ---------------------------------------------------------------------------

#pragma hdrstop

#include "Stack.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)

Node::Node(int _key) : next(nullptr), key(_key) {
};

Stack::Stack() : head(nullptr) {
};

void Stack::push(int _num) {

	Node *nd = new Node(_num);
	nd->next = this->head;
	this->head = nd;
}

bool Stack::find(int _key) {
	Node *current = this->head;
	while (current) {
		if (current->key == _key) {
			return 1;
		}
        current = current->next;
	}
	return 0;
}

bool Stack::pop(int _key) {

	Node* current = this->head;
	if (!current) {
		return 0;
	}

	if (current->key == _key) {
		this->head = this->head->next;
		delete current;
		return 1;
	}

	while (current->next) {
		if (current->next->key == _key) {
			Node* del = current->next;
			current->next = del->next;
			delete del;
			return 1;
		}
		current = current->next;
	}
	return 0;
}

void Stack::pop_even(){
	Node* current = this->head;
	while(1){
		if (!current) {
			return;
		}

		if (current->key % 2 == 0) {
			this->head = this->head->next;
			delete current;
			current = this->head;
			continue;
		}

		break;
	}

	while (current && current->next) {
		if (current->next->key % 2 == 0) {
			Node* del = current->next;
			current->next = del->next;
			delete del;
		}
		current = current->next;
	}
}

void Stack::display(TMemo* Memo){
	Node* current = head;
	while(current){
		Memo->Text = Memo->Text + current->key;
		if (current->next) {
			Memo->Text += " -> ";
		}
		current = current->next;
	}
}

void Stack::free(){
	Node* current = this->head;
	Node* temp;
	for (int i = 0; current; i++) {
		temp = current;
		current = current->next;
		delete temp;
	}
	this->head = nullptr;
}
