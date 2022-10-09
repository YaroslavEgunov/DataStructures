#include <iostream>

using namespace std;

int main()
{
    //TODO: code style +
    const int ArraySize = 10;
    double* array = new double[ArraySize]{ 3, 45, -23, 42, -2.34, 23, -5, 3.41, 4, -45 };
    cout << "Your array:" << endl;

    for (int i = 0; i < ArraySize; i++)
    {
        cout << array[i] << " ";
    }

    for (int i = 0; i < ArraySize; i++)
    {
        for (int j = i+1; j < ArraySize; j++)
        {
            if (array[i] > array[j])
            {
                double temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }

    cout << endl;
    cout << "Sorted array:" << endl;

    for (int i = 0; i < ArraySize; i++)
    {
        cout << array[i] << " ";
    }

    delete[] array;
}