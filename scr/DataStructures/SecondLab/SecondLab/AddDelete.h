#pragma once
#include <iostream>
#include "Array.h"

using namespace std;

struct AddDelete
{
	static void DeleteElement(Array* propertyName);
	static void AddFirstElement(Array* propertyName);
	static void AddLastElement(Array* propertyName);
	static void AddElement(Array* propertyName);
};
