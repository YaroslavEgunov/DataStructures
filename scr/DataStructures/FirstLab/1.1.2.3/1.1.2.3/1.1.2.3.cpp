#include <iostream>
using namespace std;

int main()
{
    const int ArraySize = 8;
    char array[ArraySize];
    cout << "Enter array of 8 chars" << endl;

    //TODO: в переменную +
    for (int i = 0; i < ArraySize; i++)
    {
        cout << "a[" << i << "]: ";
        cin >> array[i];
    }

    cout << "Your array is:" << endl;

    for (char symbol : array)
    {
        cout << symbol << " ";
    }

    cout << endl << "All letters in your array:" << endl;

    for (int i = 0; i < ArraySize; i++)
    {
        //TODO: через символы +
        if (isalpha(array[i]))
        {
            cout << array[i] << " ";
        }
    }
}
