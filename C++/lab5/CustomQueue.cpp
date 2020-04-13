//---------------------------------------------------------------------------

#pragma hdrstop

#include "CustomQueue.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)

custom_queue::custom_queue(): queue(), max_node(nullptr){};

void custom_queue::search_max()
{
	node* current = this->head;
	node* new_max = current;
	while(current)
	{
		if (current->num > new_max->num) {
			new_max = current;
		}
		current = current->next;
	}
	this->max_node = new_max;
}

void custom_queue::task_pop(queue &q1)
{
	if (this->max_node == nullptr){
		this->head = q1.get_head();
		this->tail = q1.get_tail();
		return;
	}

	else if (this->max_node == this->tail){
		this->tail = q1.get_tail();
		this->max_node->next = q1.get_head();
		q1.head_prev(this->max_node);
		return;
	}

	this->max_node->next->prev = q1.get_tail();
	q1.tail_next(this->max_node->next);
	this->max_node->next = q1.get_head();
	q1.head_prev(this->max_node);
}

int custom_queue::operator[](const int index)
{
	int i = 0;
	node* current = this->head;
	while (i < index)
	{
		i++;
		current = current->next;
	}
	return current->num;
}

void custom_queue::remove(node* nd)
{
	if (!nd)
        return;
	if (nd->next)
		nd->next->prev = nd->prev;
	else if (nd->prev)
		nd->prev->next = nullptr;
	if (nd->prev)
		nd->prev->next = nd->next;
	else if (nd->next)
        nd->next->prev = nullptr;
}

