//---------------------------------------------------------------------------

#pragma hdrstop

#include "Hash.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)

Hash::Hash(int _size){
	hash_size = _size;
	hash_arr = new Stack*[_size];
	for (int i = 0; i < _size; i++) {
        hash_arr[i] = nullptr;
	}
}

int Hash::hash_func(int _key){
	return _key % hash_size;
}

bool Hash::add(int _key){
	int index = hash_func(_key);
	if (!hash_arr[index]) {
		hash_arr[index] = new Stack();
		hash_arr[index]->push(_key);
		return 1;
	}

	//из-за этой части кода вполне может оказаться, что количество данных, которые
	//мы указали добавить в таблицу, меньше, чем отображается в Мемо,
	//на самом деле, рандомайзер может давать одинаковые выходные данные,
    //несмотря на seed по времени
	else{
		if(!hash_arr[index]->find(_key)){
			hash_arr[index]->push(_key);
			return 1;
		}

		return 0;
	}
}

bool Hash::find(int _key){
	int index = hash_func(_key);
	if (hash_arr[index]) {
		return hash_arr[index]->find(_key);
	}
	return 0;
}

bool Hash::del(int _key){
	int index = this->hash_func(_key);
	if (hash_arr[index]) {
		hash_arr[index]->pop(_key);
	}
	return 0;
}

void Hash::del_hash(){
	for (int i = 0; i < hash_size; i++) {
		if (hash_arr[i]) {
			hash_arr[i]->free();
		}
	}
	delete [] hash_arr;
	hash_arr = nullptr;
	hash_size = 0;
}

void Hash::pop_even(){
	for (int i = 0; i < hash_size; i++) {
        if (hash_arr[i]) {
			hash_arr[i]->pop_even();
		}
	}
}

void Hash::display(TMemo* Memo){
	Memo->Lines->Clear();
	for (int i = 0; i < hash_size; i++) {
		Memo->Text += "| ";
		if (hash_arr[i]) {
			hash_arr[i]->display(Memo);
		}
        Memo->Lines->Add("");
	}
}
