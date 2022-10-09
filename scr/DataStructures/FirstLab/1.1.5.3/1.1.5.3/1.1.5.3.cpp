#include <iostream>

using namespace std;

int main()
{
    //TODO: code style +
    int  ArraySize;
    cout << "Enter char array size: ";
    cin >> ArraySize;
    cout << endl;
    char* array = new char[ArraySize];

    for (int i = 0; i < ArraySize; i++)
    {
        cout << "Enter a[" << i << "]:";
        cin >> array[i];
    }

    cout << "Your char array:" << endl;

    for (int i = 0; i < ArraySize; i++)

    {
        cout << array[i] << " ";
    }

    delete[] array;
}