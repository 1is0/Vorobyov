//---------------------------------------------------------------------------
#pragma hdrstop
#include <math.hpp>
#include "Unit2.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)

num_node::num_node(double number): next(nullptr), number(number){};

num_stack::num_stack(): head(nullptr){};

//adding new num while assigning to RPN
void num_stack::push(double number)
{
	num_node *nd = new num_node(number);
	nd->next = this->head;
    this->head = nd;
}

//use if expression is wrong: wrong "()" or num_stack::amount != oper_stack::amount+1
void num_stack::free()
{
	num_node* current = this->head;
	num_node* temp;
	for (int i = 0; current; i++)
	{
		temp = current;
		current = current->next;
		delete temp;
	}
    this->head = nullptr;
}

//pop function used inside the stack to count the resulting value of expression
void num_stack::count(char operand)
{
	switch(operand)
	{
		case '+':
		{
			this->head->next->number += this->head->number;
			break;
		}

		case '-':
		{
			this->head->next->number -= this->head->number;
			break;
		}

		case '/':
		{
			this->head->next->number /= this->head->number;
			break;
		}

		case '*':
		{
			this->head->next->number *= this->head->number;
			break;
		}
	}
	num_node* temp = this->head;
	this->head = this->head->next;
	delete temp;
}

//get result in the end of [num_stack::count] cycle
double num_stack::get_result()
{
	double result = this->head->number;
	delete this->head;
	return SimpleRoundTo(result, -3);
}
