#include "AddDelete.h"
#include "Operations.h"

void AddDelete::DeleteElement(Array* propertyName)
{
    cout << "Insert index of element you want to delete:";
    int index;
    cin >> index;

    if (index > propertyName->Length - 1)
    {
        cout << "Incorrect index" << endl;
        return;
    }

    if (!cin)
    {
        cin.clear();
        cin.ignore(32767, '\n');
        cout << "Incorrect value" << endl;
        return;
    }

    int* temp = new int[propertyName->Length - 1];

    for (int i = 0; i < propertyName->Length; i++)
    {
        if (i < index)
        {
            temp[i] = propertyName->DynamicArray[i];
        }
        else
        {
            if (i == index)
            {
                continue;
            }
            temp[i - 1] = propertyName->DynamicArray[i];
        }
    }

    propertyName->DynamicArray = temp;
    propertyName->Length = propertyName->Length - 1;

}

void AddDelete::AddFirstElement(Array* propertyName)
{
    if (propertyName->Length == propertyName->Capacity)
    {
        cout << "Capacity is maximum" << endl;
        return;
    }

    cout << "Insert element you want to add first:";
    int element;
    cin >> element;

    if (!cin)
    {
        cin.clear();
        cin.ignore(32767, '\n');
        cout<<"Incorrect value"<< endl;
        return;
    }

    int* temp = new int[propertyName->Length + 1];
    temp[0] = element;

    for (int i = 1; i < propertyName->Length + 1; i++)
    {
        temp[i] = propertyName->DynamicArray[i - 1];
    }

    propertyName->DynamicArray = temp;
    propertyName->Length = propertyName->Length + 1;
}

void AddDelete::AddLastElement(Array* propertyName)
{
    if (propertyName->Length == propertyName->Capacity)
    {
        cout << "Capacity is maximum" << endl;
        return;
    }

    cout << "Insert element you want to add last:";
    int element;
    cin >> element;

    if (!cin)
    {
        cin.clear();
        cin.ignore(32767, '\n');
        cout << "Incorrect value" << endl;
        return;
    }

    int* temp = new int[propertyName->Length + 1];

    for (int i = 0; i < propertyName->Length; i++)
    {
        temp[i] = propertyName->DynamicArray[i];
    }

    temp[propertyName->Length] = element;
    propertyName->DynamicArray = temp;
    propertyName->Length = propertyName->Length + 1;
}

void AddDelete::AddElement(Array* propertyName)
{
    if (propertyName->Length == propertyName->Capacity)
    {
        cout << "Capacity is maximum" << endl;
        return;
    }

    cout << "Insert index of element you want to add:";
    int index;
    cin >> index;

    if (!cin)
    {
        cin.clear();
        cin.ignore(32767, '\n');
        cout << "Incorrect value" << endl;
        return;
    }

    cout << "Insert element you want to add:";
    int element;
    cin >> element;

    if (!cin)
    {
        cin.clear();
        cin.ignore(32767, '\n');
        cout << "Incorrect value" << endl;
        return;
    }

    if (index > propertyName->Length)
    {
        cout << "Incorrect index" << endl;
        return;
    }

    int* temp = new int[propertyName->Length + 1];
    bool elementAdded = false;

    for (int i = 0; i < propertyName->Length + 1; i++)
    {
        if (index == i)
        {
            temp[i] = element;
            elementAdded = true;
        }

        if (elementAdded == false)
        {
            temp[i] = propertyName->DynamicArray[i];
        }
        else
        {
            temp[i+1] = propertyName->DynamicArray[i];
        }
    }

    propertyName->DynamicArray = temp;
    propertyName->Length = propertyName->Length + 1;
}