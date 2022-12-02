#include "Operations.h"
#include <iostream>
#include "Array.h"
using namespace std;

void Operations::InitializeArray(int* array, int length)
{
	for (int i = 0; i < length;i++)
	{
		int element;
		cout << "a[" << i << "] = ";
		cin >> element;

		if (!cin)
		{
			throw invalid_argument("Incorrect value");
		}

		array[i] = element;		
	}
}

void Operations::ShowArray(int* array, int length)
{
	cout << "Your array:" << endl;

	for (int i = 0;i < length;i++)
	{
		cout << "a[" << i << "] = " << array[i] << endl;
	}
}
