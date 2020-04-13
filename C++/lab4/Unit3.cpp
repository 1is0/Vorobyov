//---------------------------------------------------------------------------

#pragma hdrstop

#include "Unit3.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)

oper_node::oper_node(char operand): next(nullptr), operand(operand){};

oper_stack::oper_stack(): head(nullptr), tail(nullptr){};

//use if expression is wrong
void oper_stack::free()
{
	oper_node* current = this->head;
	oper_node* temp;
	for (int i = 0; current; i++)
	{
		temp = current;
		current = current->next;
		delete temp;
	}
	this->head = nullptr;
}

//getting another symbol while counting
char oper_stack::pop()
{
	oper_node* temp = this->head;
	if (temp == nullptr)
		return '\0';
	char ch = temp->operand;
	this->head = temp->next;
	delete temp;
	return ch;

}

//adding symbol to stack using RPN symbol logic
bool oper_stack::push(char operand, AnsiString &rpn)
{
	if (operand == '(') {
		oper_node *nd = new oper_node(operand);
		nd->next = this->head;
		this->head = nd;
		return 1;
	}

	if (operand == ')') {
		oper_node *current = this->head;
		while (current->next != nullptr && current->next->operand != '(')
		{
			rpn = rpn + this->pop() + ' ';
            current = this->head;
		}

		if (current->next != nullptr) {
        	rpn = rpn + this->pop() + ' ';
			oper_node *del = current->next;
			this->head = del->next;
			delete del;
			return 1;
		}

		else
			return 0;
	}

	else{
		int current_priority, next_priority;

		switch (operand) {
			case '-':
			case '+':
				current_priority = 1;
				break;
			case '(':
				current_priority = 0;
				break;
			case '*':
			case '/':
				current_priority = 2;
				break;
		}

		while (1)
		{
			if (!this->head) {
				break;
			}

			switch (this->head->operand) {
				case '-':
				case '+':
					next_priority = 1;
					break;
				case '(':
					next_priority = 0;
					break;
				case '*':
				case '/':
					next_priority = 2;
                    break;
			}

			if (current_priority <= next_priority && this->head != nullptr) {
				rpn = rpn + this->pop() + ' ';
			}
			else
				break;
		}
		oper_node *nd = new oper_node(operand);
		nd->next = this->head;
		this->head = nd;
		return 1;
	}
}

