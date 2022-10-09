#include <iostream>

using namespace std;

int main()
{
    char* array = new char[15]{ 'k', '#', '@', '6', '^', 'r', '!', '(', 'u', 'g', '2', '*', '&', '?', '^' };
    cout << "Char array:" << endl;
    for (int i = 0; i < 15; i++)
    {
        cout << array[i] << " ";
    }
    cout << endl << "Letters in array:" << endl;
    for (int i = 0; i < 15; i++)
    {
        if (97 <= array[i] && array[i] <= 122)
        {
            cout << array[i] << " ";
        }
    }
    delete[] array;
}