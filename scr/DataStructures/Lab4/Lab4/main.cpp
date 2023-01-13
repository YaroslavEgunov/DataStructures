#include "Dictionary.h"
#include <iostream>
using namespace std;

void Validate()
{
    cin.clear();
    cin.ignore(32767, '\n');
}

int main()
{
    Dictionary* dictionary = new Dictionary;

    while (true)
    {
        cout << "---- Dictionary ----\n"
            "1. Add\n"
            "2. Remove\n"
            "3. Find\n"
            "4. Print\n"
            "5. Exit" << endl;

        int key;
        cin >> key;
        if (!cin)
        {
            Validate();
        }

        switch (key)
        {
        case 1:
        {
            cout << "Enter key: ";
            cin >> dictionary->Key;
            cout << "Enter value: ";
            cin >> dictionary->Value;
            dictionary->Add(dictionary->Key.data(), dictionary->Value.data());
            break;
        }
        case 2:
        {
            cout << "Enter key: ";
            cin >> dictionary->Key;
            dictionary->Remove(dictionary->Key.data());
            break;
        }
        case 3:
        {
            cout << "Enter key: ";
            cin >> dictionary->Key;
            const char* value = dictionary->Find(dictionary->Key.data());
            if (value == nullptr)
            {
                cout << "Key not found" << endl;
            }
            else
            {
                cout << "Value: " << value << endl;
            }
            break;
        }
        case 4:
        {
            dictionary->Print();
            break;
        }
        case 5:
        {
            return 0;
        }
        default:
        {
            cout << "Invalid value\n" << endl;
            break;
        }
        }
    }
}