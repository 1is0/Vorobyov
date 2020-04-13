//---------------------------------------------------------------------------
#pragma once
#ifndef QueueH
#define QueueH
//---------------------------------------------------------------------------
#endif

struct node{
	node* next;
	node* prev;
	int num;
	node(int num);
};

class queue{
protected:
	node* tail;
	node* head;
public:
	queue();
	node* pop();
	int push();
	node* get_tail();
	node* get_head();
	void head_prev(node *prev);
	void tail_next(node *next);
	void move_head();
};
