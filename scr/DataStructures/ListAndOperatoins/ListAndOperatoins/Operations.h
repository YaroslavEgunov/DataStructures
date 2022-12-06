#pragma once
#include "List.h"
static class Operations
{
public:
	static void Delete(List* list, int index);
	static void InsertBefore(List* list, int index, int data);
	static void InsertAfter(List* list, int index, int data);
	static void AddTail(int data, List* list);
	static void AddHead(int data, List* list);
	static void Show(List* list);
	static void InitializeList(List* list);
	static void Sort(List* list);
	static void LinearSearch(List* list, int searchValue);
	static void Validate();
};