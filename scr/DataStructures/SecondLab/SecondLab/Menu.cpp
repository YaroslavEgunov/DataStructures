#include "Menu.h"
#include "Array.h"
#include "SortAndSearch.h"
#include "AddAndDelete.h"
#include "Operations.h"

void Menu::MainMenu()
{
    Array* DynamicArray = new Array;
    int* array = new int[8]{};
    int capacity = 8;
    int length = 8;
    DynamicArray->DynamicArray = array;
    DynamicArray->Capacity = capacity;
    DynamicArray->Length = length;

    int key = -1;

    do
    {
        cout << "Press 1 to initialize array" << endl;
        cout << "Press 2 to show array" << endl;
        cout << "Press 3 to sort array" << endl;
        cout << "Press 4 to do linear search" << endl;
        cout << "Press 5 to do binary search" << endl;
        cout << "Press 6 to delete element in array" << endl;
        cout << "Press 7 to add first element in array" << endl;
        cout << "Press 8 to add last element in array" << endl;
        cout << "Press 9 to add specific element in array" << endl;
        cin >> key;
        try
        {
            switch (key)
            {
            case 1:
                Operations::InitializeArray(DynamicArray->DynamicArray, DynamicArray->Length);
                cout << endl;
                break;
            case 2:
                Operations::ShowArray(DynamicArray->DynamicArray, DynamicArray->Length);
                cout << endl;
                break;
            case 3:
                SortAndSearch::SortAscending(DynamicArray->DynamicArray, DynamicArray->Length);
                cout << endl;
                break;
            case 4:
                SortAndSearch::LinearSearch(DynamicArray->DynamicArray, DynamicArray->Length);
                cout << endl;
                break;
            case 5:
                SortAndSearch::BinarySearch(DynamicArray->DynamicArray, DynamicArray->Length);
                cout << endl;
                break;
            case 6:
                AddAndDelete::DeleteElement(DynamicArray);
                cout << endl;
                break;
            case 7:
                AddAndDelete::AddFirstElement(DynamicArray);
                cout << endl;
                break;
            case 8:
                AddAndDelete::AddLastElement(DynamicArray);
                cout << endl;
                break;
            case 9:
                AddAndDelete::AddElement(DynamicArray);
                cout << endl;
                break;
            case 0:
                break;
            default:
                cout << "Incorrect command\n" << endl;
                break;
            }
        }
        catch (exception ex)
        {
            cout << "Wrong format" << endl;
            break;
        }
    }while (key != 0);
}
