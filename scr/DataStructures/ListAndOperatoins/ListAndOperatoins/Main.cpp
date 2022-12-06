#include <iostream>
#include "List.h"
#include "ListOperations.h"
#include "Node.h"
#include <chrono>
using namespace std;
using namespace chrono;
int main()
{
    List* DoubleList = new List;
    DoubleList->Count = 0;
    int key = -1;
    string InitializeText = "Press 1 to Initialize List\n";
    string ShowText = "Press 2 to Show List\n";
    string AddHeadText = "Press 3 to Add Head Element\n";
    string AddTailText = "Press 4 to Add Tail Element\n";
    string AddAfterText = "Press 5 to Add Element After Index\n";
    string AddBeforeText = "Press 6 to Add Element Before Index\n";
    string DeleteText = "Press 7 to Delete Element\n";
    string SortText = "Press 8 to Sort List\n";
    string SearchText = "Press 9 to Search Element\n";
    string ExitText = "Press 0 to Exit Program\n ";
    string MenuText = InitializeText + ShowText +
        AddHeadText + AddTailText + AddAfterText +
        AddBeforeText + DeleteText + SortText +
        SearchText + ExitText;
   /* chrono::steady_clock::time_point begin = chrono::steady_clock::now();
    int indexForTime = -1;
    for (int i = 0; i < 1000000; i++)
    {
        ListOperations::AddHead(i, DoubleList);
        indexForTime = i;
    }
    ListOperations::InsertAfter(DoubleList, 999999, 0);
    chrono::steady_clock::time_point end = chrono::steady_clock::now();
    cout << "Runtime in seconds is = " << (chrono::duration_cast <chrono::microseconds>(end - begin).count()) / 1000000.0 << endl;
    key = 0;*/
    while (key != 0)
    {
        cout << MenuText << endl;
        cin >> key;
        if (!cin)
        {
            ListOperations::Validate();
            cout << "Can't understand command, here your list instead:" << endl;
            key = 2;
        }
        switch (key)
        {
        case 1:
            ListOperations::InitializeList(DoubleList);
            break;
        case 2:
            ListOperations::ShowList(DoubleList);
            break;
        case 3:
            cout << "Insert element you want to add: ";
            int data;
            cin >> data;
            if (!cin)
            {
                ListOperations::Validate();
                break;
            }
            ListOperations::AddHead(data, DoubleList);
            break;
        case 4:
            cout << "Insert element you want to add: ";
            cin >> data;
            if (!cin)
            {
                ListOperations::Validate();
                break;
            }
            ListOperations::AddTail(data, DoubleList);
            break;
        case 5:
            cout << "Insert element you want to add: ";
            cin >> data;
            if (!cin)
            {
                ListOperations::Validate();
                break;
            }
            cout << "Insert index after which you want to add: ";
            int index;
            cin >> index;
            if (!cin)
            {
                ListOperations::Validate();
                break;
            }
            ListOperations::InsertAfter(DoubleList, index, data);
            break;
        case 6:
            cout << "Insert element you want to add: ";
            cin >> data;
            if (!cin)
            {
                ListOperations::Validate();
                break;
            }
            cout << "Insert index before which you want to add: ";
            cin >> index;
            if (!cin)
            {
                ListOperations::Validate();
                break;
            }
            ListOperations::InsertBefore(DoubleList, index, data);
            break;
        case 7:
            cout << "Insert index of element you want to delete: ";
            cin >> index;
            if (!cin)
            {
                ListOperations::Validate();
                break;
            }
            ListOperations::Remove(DoubleList, index);
            break;
        case 8:
            ListOperations::SortList(DoubleList);
            break;
        case 9:
            cout << "Insert element you want to search: ";
            int element;
            cin >> element;
            if (!cin)
            {
                ListOperations::Validate();
                break;
            }
            ListOperations::SearchList(DoubleList, element);
            break;
        default:
            cout << "Incorrect command" << endl;
            break;
        }
    }
    delete DoubleList;
}