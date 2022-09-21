// 1.1.2.1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
using namespace std;

#include <iostream>

int main()
{
	// int array[10] = { 34, -24, 12, 44, -65, 52, -72, 12, 87, -10 };
	int array[10];
	srand(time(0));
	cout << "Source array is: ";

	for (int i=0; i<10; i++)
	{
		array[i] =  1 + rand() % 200 + (-100);
		cout << array[i] << " ";
	}

	for (int i = 0; i < 10; i++)
	{
		for (int j = i+1; j < 10; j++)
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

	for (int i = 0; i < 10; i++)
	{
		cout << array[i] << " ";
	}
}
