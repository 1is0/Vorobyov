//---------------------------------------------------------------------------
#pragma once
#include "Queue.h"
#ifndef CustomQueueH
#define CustomQueueH
//---------------------------------------------------------------------------
#endif

class custom_queue: public queue{
	node* max_node;
public:
	custom_queue();
	void search_max();
	void task_pop(queue &q1);
	int operator[](const int index);
	void remove(node* nd);
};