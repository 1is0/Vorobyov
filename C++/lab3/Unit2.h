//---------------------------------------------------------------------------
#ifndef Unit2H
#define Unit2H
//---------------------------------------------------------------------------
#endif

class List{
	class Node{
	public:
		Node *pnext;
		AnsiString group;
		AnsiString mark;
		AnsiString ticket_num;
		AnsiString date;
		bool state;
		Node(AnsiString &gr, AnsiString &mrk, AnsiString &tckt, AnsiString &dt, bool &st, Node *pnext);
	};
	Node *phead;
	int size;
public:
	List();
	Node* operator[](const int index);
	void push_head(AnsiString &gr, AnsiString &mrk, AnsiString &tckt, AnsiString &dt, bool &st);
	void pop_out(AnsiString num);
	Node* find_node(AnsiString num);
	int get_size();
	void edit_node(AnsiString &gr, AnsiString &mrk, AnsiString &tckt, AnsiString &dt, bool &st, Node* nd);
	void get_node(AnsiString &gr, AnsiString &mrk, AnsiString &tckt, AnsiString &dt, bool &st, Node* nd);
};
