#include <iostream>

using namespace std;

int main()
{
    int* array = new int[10]{ 1, 23, 345 , 2, -56, -23, -4, 26, 3, -10};
    cout << "Array:" << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << array[i] << " ";
    }
    cout << endl;
    int searchValue;
    int valueIndex = -1;
    cout << "Enter searching value: ";
    cin >> searchValue;
    cout << endl;
    for (int i = 0; i < 10; i++)
    {
        if (array[i] == searchValue)
        {
            valueIndex = i;
        }
    }
    if (valueIndex != -1)
    {
        cout << "Index of searching value " << searchValue << " is: " << valueIndex;
    }
    else
    {
        cout << "Index of searching value " << searchValue << " not found";
    }
    delete[] array;
}