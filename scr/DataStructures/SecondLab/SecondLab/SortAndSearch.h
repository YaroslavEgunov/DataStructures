#pragma once
#include <iostream>
#include "Array.h"

using namespace std;

struct SortAndSearch
{
	static void SortAscending(int* array, int length);
	static void LinearSearch(int* array, int length);
	static void BinarySearch(int* array, int length);
};
