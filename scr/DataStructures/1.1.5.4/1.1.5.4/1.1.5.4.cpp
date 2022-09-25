#include <iostream>

using namespace std;

int main()
{
    double* array = new double[10]{ 3, 45, -23, 42, -2.34, 23, -5, 3.41, 4, -45 };
    cout << "Your array:" << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << array[i] << " ";
    }
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            if (array[j] > array[j + 1])
            {
                double temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    cout << endl;
    cout << "Sorted array:" << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << array[i] << " ";
    }
    delete[] array;
}