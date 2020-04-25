//---------------------------------------------------------------------------

#ifndef oper_stackH
#define oper_stackH
//---------------------------------------------------------------------------
#endif

struct OperNode
{
	OperNode* next;
	char operand;
	OperNode(char operand);
};

class OperStack
{
	OperNode* head;
	OperNode* tail;
public:
	OperStack();
	bool push(char operand, AnsiString &rpn);
	void free();
	char pop();
};

