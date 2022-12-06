#include "List.h"
#include "Node.h"
#include "Operations.h"
#include <iostream>
using namespace std;

void Operations::InitializeList(List* list)
{
    for (int i = 5; i >= 0; i--)
    {
        AddHead(i, list);
    }

    Show(list);
}

void Operations::Show(List* list)
{
    Node* temp = list->Head;
    int i = 0;
    cout << "Your list:" << endl;

    while (temp != NULL)
    {
        cout << "Node " << i << ": " << temp->Data << endl;
        temp = temp->Next;
        i++;
    }

    cout << endl;
}

void Operations::Delete(List* list, int index)
{
    if (index < 0 || index >= list->Count)
    {
        cout << "Incorrect index\n";
        return;
    }

    int i = 0;
    Node* deleteElem = list->Head;

    while (i < index)
    {
        deleteElem = deleteElem->Next;
        i++;
    }

    Node* prevDelete = deleteElem->Prev;
    Node* afterDelete = deleteElem->Next;

    if (prevDelete != 0 && list->Count != 1)
    {
        prevDelete->Next = afterDelete;
    }

    if (afterDelete != 0 && list->Count != 1)
    {
        afterDelete->Prev = prevDelete;
    }

    if (index == 0)
    {
        list->Head = afterDelete;
    }

    if (index == list->Count--)
    {
        list->Tail = prevDelete;
    }

    delete deleteElem;
    list->Count--;
}

void Operations::AddHead(int data, List* list)
{
    Node* temp = new Node;
    temp->Prev = nullptr;
    temp->Data = data;
    temp->Next = list->Head;

    if (list->Head != nullptr)
    {
        list->Head->Prev = temp;
    }

    if (list->Count == 0)
    {
        list->Head = list->Tail = temp;
    }
    else
    {
        list->Head = temp;
    }

    list->Count++;
}

void Operations::AddTail(int data, List* list)
{
    Node* temp = new Node;
    temp->Next = nullptr;
    temp->Data = data;
    temp->Prev = list->Tail;

    if (list->Tail != nullptr)
    {
        list->Tail->Next = temp;
    }

    if (list->Count == 0)
    {
        list->Head = list->Tail = temp;
    }
    else
    {
        list->Tail = temp;
    }

    list->Count++;
}

void Operations::InsertAfter(List* list, int index, int data)
{
    if (index < 0 || index > list->Count--)
    {
        cout << "Incorrect index\n";
        return;
    }

    if (index == list->Count--)
    {
        AddTail(data, list);
        return;
    }
    else if (index == 0)
    {
        AddHead(data, list);
        return;
    }

    int i = 0;
    Node* insertElem = list->Head;

    while (i <= index)
    {
        insertElem = insertElem->Next;
        i++;
    }

    Node* prevInsert = insertElem->Prev;
    Node* temp = new Node;
    temp->Data = data;

    if (prevInsert != 0 && list->Count != 1)
    {
        prevInsert->Next = temp;
    }

    temp->Next = insertElem;
    temp->Prev = prevInsert;
    insertElem->Prev = temp;
    list->Count++;
}

void Operations::InsertBefore(List* list, int index, int data)
{
    if (index < 0 || index > list->Count)
    {
        cout << "Incorrect index\n";
        return;
    }

    if (index == list->Count--)
    {
        AddTail(data, list);
        return;
    }
    else if (index == 0)
    {
        AddHead(data, list);
        return;
    }

    int i = 0;
    Node* insertElem = list->Head;

    while (i < index)
    {
        insertElem = insertElem->Next;
        i++;
    }

    Node* prevInsert = insertElem->Prev;
    Node* temp = new Node;
    temp->Data = data;

    if (prevInsert != 0 && list->Count != 1)
    {
        prevInsert->Next = temp;
    }

    temp->Next = insertElem;
    temp->Prev = prevInsert;
    insertElem->Prev = temp;
    list->Count++;
}

void Operations::Sort(List* list)
{
    int temp = 0;
    bool flag = 1;
    Node* firstNode = nullptr;
    Node* secondNode = nullptr;

    while (flag == 1)
    {
        firstNode = list->Head;
        secondNode = firstNode->Next;
        flag = 0;

        while (secondNode)
        {
            if ((firstNode->Data) > (secondNode->Data))
            {
                temp = firstNode->Data;
                firstNode->Data = secondNode->Data;
                secondNode->Data = temp;
                flag = 1;
            }

            firstNode = firstNode->Next;
            secondNode = secondNode->Next;
        }
    }
}

void Operations::LinearSearch(List* list, int searchValue)
{
    Node* current = list->Head;
    int i = 0;

    while (current != nullptr)
    {
        if (current->Data == searchValue)
        {
            cout << "Your element " << searchValue << " was found with index " << i << endl;
            return;
        }

        current = current->Next;
        i++;
    }
    cout << "Your element " << searchValue << " wasn't found" << endl;
}

void Operations::Validate()
{
    cout << "Incorrect value" << endl;
    cin.clear();
    cin.ignore(32767, '\n');
}