#include <iostream>

using namespace std;

int main()
{
    //TODO: code style +
    const int ArraySize = 6;
    bool* array = new bool[ArraySize]{ 1, 0, 1, 0, 1, 0 };
    cout << "Array of bool:" << endl;

    for (int i = 0; i < ArraySize; i++)
    {
        cout << array[i] << " ";
    }

    delete[] array;
}