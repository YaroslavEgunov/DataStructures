#include <iostream>
#include <cmath>

using namespace std;

double GetPower(double base, int exponent)
{
    cout << base << " ^ " << exponent << " = ";
    return pow(base, exponent);
}

void DemoGetPower(double base, int exponent)
{
    cout << GetPower(base, exponent) << endl;
}

int main()
{
    //TODO: убрать вызов
    cout << GetPower(3, 7) << endl;
    cout << GetPower(-6.2, 4) << endl;
    cout << GetPower(1.7, 12) << endl;
    DemoGetPower(5, 5);
    DemoGetPower(-3, 3);
    DemoGetPower(999999, 0);
}