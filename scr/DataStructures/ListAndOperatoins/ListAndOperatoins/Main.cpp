#include <iostream>
#include "List.h"
#include "Operations.h"
#include "Node.h"
#include <chrono>
using namespace std;
using namespace chrono;

int main()
{
    List* DoubleList = new List;
    DoubleList->Count = 0;
    int key = -1;

    do
    {
        cout << "Press 1 to Initialize List\n"
            "Press 2 to Show List\n"
            "Press 3 to Delete Element\n"
            "Press 4 to Add Head Element\n"
            "Press 5 to Add Tail Element\n"
            "Press 6 to Add Element After Index\n"
            "Press 7 to Add Element Before Index\n"
            "Press 8 to Sort List\n"
            "Press 9 to Search Element\n" << endl;
        cin >> key;

        if (!cin)
        {
            Operations::Validate();
            key = 2;
        }

        switch (key)
        {
            case 1:
            { 
                Operations::InitializeList(DoubleList);
                break;
            }
            case 2:
            {
                Operations::Show(DoubleList);
                break;
            }
            case 3:
            {
                int index;
                cout << "Insert index of element you want to delete: ";
                cin >> index;

                if (!cin)
                {
                    Operations::Validate();
                    break;
                }

                Operations::Delete(DoubleList, index);
                break;
            }
            case 4:
            {
                cout << "Insert element you want to add: ";
                int data;
                cin >> data;

                if (!cin)
                {
                    Operations::Validate();
                    break;
                }

                Operations::AddHead(data, DoubleList);
                break;
            }
            case 5:
            {
                cout << "Insert element you want to add: ";
                int data;
                cin >> data;

                if (!cin)
                {
                    Operations::Validate();
                    break;
                }

                Operations::AddTail(data, DoubleList);
                break;
            }
            case 6:
            {
                cout << "Insert element you want to add: ";
                int data;
                cin >> data;

                if (!cin)
                {
                    Operations::Validate();
                    break;
                }

                cout << "Insert index after which you want to add: ";
                int index;
                cin >> index;

                if (!cin)
                {
                    Operations::Validate();
                    break;
                }

                Operations::InsertAfter(DoubleList, index, data);
                break;
            }
            case 7:
            {
                int data;
                int index;
                cout << "Insert element you want to add: ";
                cin >> data;

                if (!cin)
                {
                    Operations::Validate();
                    break;
                }

                cout << "Insert index before which you want to add: ";
                cin >> index;

                if (!cin)
                {
                    Operations::Validate();
                    break;
                }

                Operations::InsertBefore(DoubleList, index, data);
                break;

               
            }
            case 8:
            {
                Operations::Sort(DoubleList);
                break;
            }
            case 9:
            {
                cout << "Insert element you want to search: ";
                int element;
                cin >> element;

                if (!cin)
                {
                    Operations::Validate();
                    break;
                }

                Operations::LinearSearch(DoubleList, element);
                break;
            }
            default:
            {
                cout << "Incorrect command" << endl;
                break;
            }
        }
    } while (key != 0);
    delete DoubleList;
}