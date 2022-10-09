#include <iostream>
using namespace std;

void RoundToTens(int& value)
{
    //TODO: 10 в переменную +
    const int RoundTo = 10;
    int remainder = value % RoundTo;

    if (remainder < 5)
    {
        cout << "For " << value << " rounded value is " << (value / RoundTo) * RoundTo << endl;
    }
    else
    {
        cout << "For " << value << " rounded value is " << (value / RoundTo + 1) * RoundTo << endl;
    }
}

int main()
{
    //TODO: лишние переменные +
    int a;
    RoundToTens(a = 34);
    RoundToTens(a = 245);
    RoundToTens(a = 999);
}
