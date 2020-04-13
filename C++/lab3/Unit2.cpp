//---------------------------------------------------------------------------
#pragma hdrstop
#include <vcl.h>
#include <mmsystem.h>
#include "Unit2.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)

List::List():phead(nullptr), size(0){}

List::Node::Node(AnsiString &gr, AnsiString &mrk, AnsiString &tckt, AnsiString &dt, bool &st, Node *pnext){
	this->pnext = pnext;
	this->group = gr;
	this->mark = mrk;
	this->ticket_num = tckt;
	this->date = dt;
	this->state = st;
}

int List::get_size()
{
	return size;
}

//search of item for get_node and edit_node
List::Node* List::find_node(AnsiString num){
	Node* current = phead;
	while (current && current->ticket_num != num)
	{
		current = current->pnext;
	}
	return current;
}

void List::edit_node(AnsiString &gr, AnsiString &mrk, AnsiString &tckt, AnsiString &dt, bool &st, Node* nd){
	nd->ticket_num = tckt;
	nd->mark = mrk;
	nd->date = dt;
	nd->group = gr;
	nd->state = st;
}

void List::get_node(AnsiString &gr, AnsiString &mrk, AnsiString &tckt, AnsiString &dt, bool &st, Node* nd)
{
	gr = nd->group;
	mrk = nd->mark;
	tckt = nd->ticket_num;
	dt = nd->date;
    st = nd->state;
}


void List::push_head(AnsiString &gr, AnsiString &mrk, AnsiString &tckt, AnsiString &dt, bool &st)
{
	Node *temp;
	try
	{
		temp = new Node(gr, mrk, tckt, dt, st, phead);
		phead = temp;
		size++;
	}

	catch(std::bad_alloc)
	{
		MessageDlg("Not enough space for new fields of list", mtWarning,mbOKCancel, 0);
		return;
	}
}

void List::pop_out(AnsiString num)
{
	if (phead->ticket_num == num)
	{
		Node* head_del = phead;
		phead = phead->pnext;
		delete head_del;
		size--;
		return;
	}
	Node* current = phead;
	while (current && (current->pnext->ticket_num != num || !current->pnext))
	{
		current = current->pnext;
	}

	if (current != nullptr) {
		current->pnext = current->pnext->pnext;
		delete current->pnext;
        size--;
	}
}

List::Node* List::operator[](const int index)
{
	int counter = 0;
	Node* current = phead;
	while (counter < index)
	{
		current = current->pnext;
        counter++;
	}
    return current;
}
