﻿#include <iostream>
using namespace std;

void RoundToTens(int& value)
{
    int remainder = value % 10;
    if (remainder < 5)
    {
        cout << "For " << value << " rounded value is " << (value / 10) * 10 << endl;
    }
    else
    {
        cout << "For " << value << " rounded value is " << (value / 10 + 1) * 10 << endl;
    }
}

int main()
{
    int a = 34;
    RoundToTens(a);
    a = 245;
    RoundToTens(a);
    a = 999;
    RoundToTens(a);
}