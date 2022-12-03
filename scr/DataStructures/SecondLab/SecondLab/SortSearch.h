#pragma once
#include <iostream>
#include "Array.h"

using namespace std;

struct SortSearch
{
	static void AscendingSort(int* array, int length);
	static void LinearSearch(int* array, int length);
	static void BinarySearch(int* array, int length);
};
