// ---------------------------------------------------------------------------
#pragma once
#ifndef StackH
#define StackH
#include <vcl.h>
// ---------------------------------------------------------------------------
#endif

struct Node {
	Node* next;
	int key;

	Node(int _key);
};

class Stack {
private:
	Node* head;

public:
	Stack();
	int get_key();

	void push(int _key);
	bool find(int _key);
	bool pop(int _key);
	void pop_even();
	void free();
    void display(TMemo* Memo);
};
