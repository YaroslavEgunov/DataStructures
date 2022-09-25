#include <iostream>

using namespace std;

int main()
{
    double* array = new double[7]{ 3.1, 23.5, -3.4, 54.3, 3.54, 1.3435, 34.6578 };
    cout << "Array of double:" << endl;
    for (int i = 0; i < 7; i++)
    {
        cout << array[i] << " ";
    }
    delete[] array;
}