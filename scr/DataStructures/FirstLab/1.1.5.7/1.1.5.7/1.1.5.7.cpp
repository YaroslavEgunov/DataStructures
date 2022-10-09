#include <iostream>
#include <cstdlib>

using namespace std;

int* MakeRandomArray(int arraySize)
{
	int* array = new int[arraySize];
	cout << "Random int array of " << arraySize << ":" << endl;

	for (int i = 0; i < arraySize; i++)
	{
		array[i] = rand() % 201 - 100;
		cout << array[i] << " ";
	}

	cout << endl;
	return array;
}

int main()
{
	int* array = MakeRandomArray(5);
	delete[] array;
	array = MakeRandomArray(8);
	delete[] array;
	array = MakeRandomArray(13);
	delete[] array;
}