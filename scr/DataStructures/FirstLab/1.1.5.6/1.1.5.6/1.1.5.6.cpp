#include <iostream>

using namespace std;

int main()
{
    const int ArraySize = 15;
    char* array = new char[ArraySize]{ 'k', '#', '@', '6', '^', 'r', '!', '(', 'u', 'g', '2', '*', '&', '?', '^' };
    cout << "Char array:" << endl;

    for (int i = 0; i < ArraySize; i++)
    {
        cout << array[i] << " ";
    }

    cout << endl << "Letters in array:" << endl;

    for (int i = 0; i < ArraySize; i++)
    {
        if (97 <= array[i] && array[i] <= 122)
        {
            cout << array[i] << " ";
        }
    }

    delete[] array;
}