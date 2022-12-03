#include "Menu.h"
#include "Array.h"
#include "SortSearch.h"
#include "AddDelete.h"
#include "Operations.h"

void Menu::MainMenu()
{
    Array* DynamicArray = new Array;
    int* array = new int[8]{};
    int capacity = 8;
    int length = 7;
    DynamicArray->DynamicArray = array;
    DynamicArray->Capacity = capacity;
    DynamicArray->Length = length;

    int key = -1;

    do
    {
        cout << "Press 1 to initialize array\n" 
            "Press 2 to show array\n"
            "Press 3 to sort array\n"
            "Press 4 to do linear search\n"
            "Press 5 to do binary search\n"
            "Press 6 to delete element in array\n"
            "Press 7 to add first element in array\n"
            "Press 8 to add last element in array\n"
            "Press 9 to add specific element in array\n";
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
                SortSearch::AscendingSort(DynamicArray->DynamicArray, DynamicArray->Length);
                cout << endl;
                break;
            case 4:
                SortSearch::LinearSearch(DynamicArray->DynamicArray, DynamicArray->Length);
                cout << endl;
                break;
            case 5:
                SortSearch::BinarySearch(DynamicArray->DynamicArray, DynamicArray->Length);
                cout << endl;
                break;
            case 6:
                AddDelete::DeleteElement(DynamicArray);
                cout << endl;
                break;
            case 7:
                AddDelete::AddFirstElement(DynamicArray);
                cout << endl;
                break;
            case 8:
                AddDelete::AddLastElement(DynamicArray);
                cout << endl;
                break;
            case 9:
                AddDelete::AddElement(DynamicArray);
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
            return;
        }
    }while (key != 0);
}
