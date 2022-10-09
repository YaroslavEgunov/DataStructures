using namespace std;

#include <iostream>

int main()
{
	//TODO: убрать комментарии +
	const int ArraySize = 10;
	int array[ArraySize] = { 34, -24, 12, 44, -65, 52, -72, 21, 87, -10 };
	cout << "Source array is: ";

	//TODO: размер вычислять +
	for (int i=0; i< ArraySize; i++)
	{
		cout << array[i] << " ";
	}

	for (int i = 0; i < ArraySize; i++)
	{
		for (int j = i+1; j < ArraySize; j++)
		{
			if (array[i] > array[j])
			{
				int temp = array[i];
				array[i] = array[j];
				array[j] = temp;
			}
		}
	}

	cout << "\nSorted array is: ";

	for (int i = 0; i < ArraySize; i++)
	{
		cout << array[i] << " ";
	}
}
