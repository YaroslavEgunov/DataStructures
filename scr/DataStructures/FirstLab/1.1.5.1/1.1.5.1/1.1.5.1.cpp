#include <iostream>

using namespace std;

int main()
{
    //TODO: размер в переменную +
    const int ArraySize = 7;
    double* array = new double[ArraySize]{ 3.1, 23.5, -3.4, 54.3, 3.54, 1.3435, 34.6578 };
    cout << "Array of double:" << endl;

    //TODO: отступы +
    for (int i = 0; i < ArraySize; i++)
    {
        cout << array[i] << " ";
    }

    delete[] array;
}