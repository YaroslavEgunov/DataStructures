#include "SortSearch.h"
#include "Operations.h"

void SortSearch::AscendingSort(int* array, int length)
{
	for (int j = 0; j < length; j++)
	{
		for (int k = j + 1; k < length; k++)
		{
			if (array[j] > array[k])
			{
				int temp = array[j];
				array[j] = array[k];
				array[k] = temp;
			}
		}
	}
}

void  SortSearch::LinearSearch(int* array, int length)
{
	int index = -1;
	int searchValue;
	cout << "Insert value you want to find: ";
	cin >> searchValue;

	if (!cin)
	{
		Operations::Validate();
		return;
	}

	for (int i = 0; i < length; i++)
	{
		if (array[i] == searchValue)
		{
			index = i;
		}
	}

	if (index == -1)
	{
		cout << "Your value wasn't found" << endl;
	}
	else
	{
		cout << "Your value " << searchValue << " has index: " << index << endl;
	}
}

void  SortSearch::BinarySearch(int* array, int length)
{
	int index = -1;
	int searchValue;
	cout << "Insert value you want to find: ";
	cin >> searchValue;

	if (!cin)
	{
		Operations::Validate();
		return;
	}

	AscendingSort(array, length);
	int left = 0;
	int right = length - 1;
	int mid;
	bool flag = false;

	while ((left <= right) && (flag != true)) 
	{
		mid = (left + right) / 2;

		if (array[mid] == searchValue)
		{
			flag = true;
		}

		if (array[mid] > searchValue)
		{
			right = mid - 1;
		}
		else
		{
			left = mid + 1;
		}
	}

	if (flag)
	{
		cout << "Your value " << searchValue << " has index: " << mid << endl;
	}
	else
	{
		cout << "Your value wasn't found" << endl;
	}
}