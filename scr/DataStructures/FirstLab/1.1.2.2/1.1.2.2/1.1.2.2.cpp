using namespace std;

#include <iostream>

int main()
{
	const int ArraySize = 12;
	double array[ArraySize] = { 34.3, -24.67, 12.17, 44.4, -65.13, 52.91, -72.36, 12.4, 87.85, -10.8 };
	cout << "Source array is: ";

	//TODO: массив в переменную +
	for (int i = 0; i < ArraySize; i++)
	{
		cout << array[i] << " ";
	}

	cout << endl << "Enter searching value: ";
	double searchValue;
	cin >> searchValue;
	cout << endl;
	int count = 0;

	for (int i = 0; i < ArraySize; i++)
	{
		if (array[i] >= searchValue)
		{
			count++;
		}
	}

	cout << "Elements of array more than " << searchValue << " : " << count;
}
