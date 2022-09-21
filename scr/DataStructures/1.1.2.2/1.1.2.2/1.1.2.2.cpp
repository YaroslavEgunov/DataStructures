// 1.1.2.2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
using namespace std;

#include <iostream>

int main()
{
	double array[12] = { 34.3, -24.67, 12.17, 44.4, -65.13, 52.91, -72.36, 12.4, 87.85, -10.8 };
	cout << "Source array is: ";

	for (int i = 0; i < 10; i++)
	{
		cout << array[i] << " ";
	}

	cout << endl << "Enter searching value: ";
	double searchValue;
	cin >> searchValue;
	cout << endl;
	int count = 0;

	for (int i = 0; i < 12; i++)
	{
		if (array[i] >= searchValue)
		{
			count++;
		}
	}

	cout << "Elements of array more than " << searchValue << " : " << count;
}
