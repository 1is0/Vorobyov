//---------------------------------------------------------------------------

#ifndef Unit3H
#define Unit3H
//---------------------------------------------------------------------------
#endif

struct oper_node
{
	oper_node* next;
	char operand;
	oper_node(char operand);
};

class oper_stack
{
	oper_node* head;
	oper_node* tail;
public:
	oper_stack();
	bool push(char operand, AnsiString &rpn);
	void free();
	char pop();
};

