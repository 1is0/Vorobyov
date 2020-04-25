//---------------------------------------------------------------------------

#ifndef num_stackH
#define num_stackH
//---------------------------------------------------------------------------
#endif

struct NumNode
{
	NumNode* next;
	double number;
	NumNode(double number);
};

class NumStack
{
	NumNode* head;
public:
	NumStack();
	void push(double number);
	void count(char operand);
	void free();
    double get_result();
};

