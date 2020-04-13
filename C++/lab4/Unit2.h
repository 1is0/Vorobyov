//---------------------------------------------------------------------------

#ifndef Unit2H
#define Unit2H
//---------------------------------------------------------------------------
#endif

struct num_node
{
	num_node* next;
	double number;
	num_node(double number);
};

class num_stack
{
	num_node* head;
public:
	num_stack();
	void push(double number);
	void count(char operand);
	void free();
    double get_result();
};

