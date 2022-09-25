
#include <iostream>
using namespace std;

int main()
{
    char array[8];
    cout << "Enter array of 8 chars" << endl;
    for (int i = 0; i < sizeof(array) / sizeof(array[0]); i++)
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
    for (int i = 0; i < sizeof(array) / sizeof(array[0]); i++)
    {
        if ((97 <= array[i] && array[i] <= 122) || (65 <= array[i] && array[i] <= 90))
        {
            cout << array[i] << " ";
        }
    }
}
