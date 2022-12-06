#pragma once
#include "List.h"
static class ListOperations
{
public:
	static void Remove(List* list, int index);
	static void InsertBefore(List* list, int index, int data);
	static void InsertAfter(List* list, int index, int data);
	static void AddTail(int data, List* list);
	static void AddHead(int data, List* list);
	static void ShowList(List* list);
	static void InitializeList(List* list);
	static void SortList(List* list);
	static void SearchList(List* list, int searchValue);
	static void Validate();
};