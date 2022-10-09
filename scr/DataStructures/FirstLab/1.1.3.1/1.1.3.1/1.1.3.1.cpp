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
    //TODO: убрать вызов +
    DemoGetPower(5, 5);
    DemoGetPower(-3, 3);
    DemoGetPower(999999, 0);
}