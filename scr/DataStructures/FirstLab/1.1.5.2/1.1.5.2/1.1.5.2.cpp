#include <iostream>

using namespace std;

int main()
{
    //TODO: code style
    bool* array = new bool[6]{ 1, 0, 1, 0, 1, 0 };
    cout << "Array of bool:" << endl;
    for (int i = 0; i < 6; i++)
    {
        cout << array[i] << " ";
    }
    delete[] array;
}