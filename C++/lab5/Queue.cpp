// ---------------------------------------------------------------------------

#pragma hdrstop
#include <stdlib.h>
#include "Queue.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)

node::node(int num) : num(num), next(nullptr), prev(nullptr) {
};

queue::queue() : head(nullptr), tail(nullptr) {
};

node* queue::pop() {
	if (this->head == nullptr)
		return nullptr;
	else {
		if (this->head->next)
			this->head->next->prev = this->head->prev;
		else if (this->head->prev)
			this->head->prev->next = nullptr;
		if (this->head->prev)
			this->head->prev->next = this->head->next;
		else if (this->head->next)
			this->head->next->prev = nullptr;
		if (this->head == this->tail) {
			this->tail = nullptr;
			delete this->head;
			node* ret = this->head;
			this->head = nullptr;
			return ret;
		}

		node* del = this->head;
		this->head = this->head->next;
		delete del;
		return del;
	}
}

int queue::push() {
	int val = rand();
	node *nd = new node(val);
	if (this->tail == nullptr)
		this->tail = this->head = nd;

	else {
		if (this->tail->next) {
			this->tail->next->prev = nd;
			nd->next = this->tail->next;
		}
		this->tail->next = nd;
		nd->prev = this->tail;
		this->tail = nd;
	}

	return val;
}

node* queue::get_tail() {
	return this->tail;
}

node* queue::get_head() {
	return this->head;
}

void queue::head_prev(node *prev) {
	this->head->prev = prev;
}

void queue::tail_next(node *next) {
	this->tail->next = next;
}

void queue::move_head()
{
	if (this->head == this->tail) {
		this->head = this->tail = nullptr;
		return;
	}
	this->head = this->head->next;
	this->head->prev = nullptr;
}
