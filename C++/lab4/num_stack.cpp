//---------------------------------------------------------------------------
#pragma hdrstop
#include <math.hpp>
#include "num_stack.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)

NumNode::NumNode(double number): next(nullptr), number(number){};

NumStack::NumStack(): head(nullptr){};

//adding new num while assigning to RPN
void NumStack::push(double number)
{
	NumNode *nd = new NumNode(number);
	nd->next = this->head;
    this->head = nd;
}

//use if expression is wrong: wrong "()" or NumStack::amount != oper_stack::amount+1
void NumStack::free()
{
	NumNode* current = this->head;
	NumNode* temp;
	for (int i = 0; current; i++)
	{
		temp = current;
		current = current->next;
		delete temp;
	}
    this->head = nullptr;
}

//pop function used inside the stack to count the resulting value of expression
void NumStack::count(char operand)
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
	NumNode* temp = this->head;
	this->head = this->head->next;
	delete temp;
}

//get result in the end of [NumStack::count] cycle
double NumStack::get_result()
{
	double result = this->head->number;
	delete this->head;
	return SimpleRoundTo(result, -3);
}
