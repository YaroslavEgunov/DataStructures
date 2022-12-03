#include <iostream>
#include "List.h"
#include "ListOperations.h"
#include "Node.h"
using namespace std;

int main()
{
    List* DoubleList = new List;
    int key = -1;
    do 
    {
        cout << "Press 1 to Initialize List\n"
                 "Press 2 to Show List\n"
                 "Press 3 to Add Head Element\n"
                 "Press 4 to Add Tail Element\n"
                 "Press 5 to Add Element After Index\n"
                 "Press 6 to Add Element Before Index\n"
                 "Press 7 to Delete Element\n"
                 "Press 8 to Sort List\n"
                 "Press 9 to Search Element\n"
                 "Press 0 to Exit Program\n" << endl;
        cin >> key;
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
            ListOperations::AddHead(data, DoubleList);
            break;
        case 4:
            cout << "Insert element you want to add: ";
            cin >> data;
            ListOperations::AddTail(data, DoubleList);
            break;
        case 5:
            cout << "Insert element you want to add: ";
            cin >> data;
            cout << "Insert index after which you want to add: ";
            int index;
            cin >> index;
            ListOperations::Insert(DoubleList, index, data, true);
            break;
        case 6:
            cout << "Insert element you want to add: ";
        	data;
            cin >> data;
            cout << "Insert index after which you want to add: ";
            cin >> index;
            ListOperations::Insert(DoubleList, index, data, false);
            break;
        case 7:
            cout << "Insert index of element you want to delete: ";
            cin >> index;
            ListOperations::Remove(DoubleList, index);
            break;
        case 8:
            ListOperations::SortList(DoubleList);
            break;
        case 9:
            cout << "Insert element you want to search: ";
            int element;
            cin >> element;
            ListOperations::SearchList(DoubleList, element);
            break;
        default:
            cout << "Incorrect command" << endl;
            break;
        }
    } while (key != 0);
}