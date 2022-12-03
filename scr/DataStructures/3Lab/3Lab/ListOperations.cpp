#include "List.h"
#include "Node.h"
#include "ListOperations.h"
#include <iostream>
using namespace std;

void ListOperations::Remove(List* list, int index)
{
    if (index < 1 || index > list->Count)
    {
        cout << "Incorrect position !!!\n";
        return;
    }

    int i = 0;
    Node* Delete = list->Head;

    while (i < index)
    {
        Delete = Delete->Next;
        i++;
    }

    Node* PrevDelete = Delete->Prev;
    Node* AfterDelete = Delete->Next;

    if (PrevDelete != 0 && list->Count != 1)
    {
        PrevDelete->Next = AfterDelete;
    }

    if (AfterDelete != 0 && list->Count != 1)
    {
        AfterDelete->Prev = PrevDelete;
    }

    if (index == 0)
    {
        list->Head = AfterDelete;
    }
    if (index == list->Count--)
    {
        list->Tail = PrevDelete;
    }
    delete Delete;
    list->Count--;
}

void ListOperations::Insert(List* list, int index, int data, bool beforeOrAfter)
{
    if (index < 0 || index > list->Count)
    {
        cout << "Incorrect position !!!\n";
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
    Node* Insert = list->Head;

    while (i < index)
    {
        Insert = Insert->Next;
        i++;
    }

    if (beforeOrAfter == true)
    {
        i++;
    }

    Node* PrevInsert = Insert->Prev;
    Node* temp = new Node;
    temp->Data = data;

    if (PrevInsert != 0 && list->Count != 1)
    {
        PrevInsert->Next = temp;
    }

    temp->Next = Insert;
    temp->Prev = PrevInsert;
    Insert->Prev = temp;
    list->Count++;
}

void ListOperations::AddTail(int data, List* list)
{
    Node* temp = new Node;
    temp->Next = 0;
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

void ListOperations::AddHead(int data, List* list)
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

void ListOperations::ShowList(List* list)
{
    Node* temp = list->Head;
    int i = 0;

    while (temp != NULL)
    {
        cout << "Node" << i << " " << temp->Data << endl;
        temp = temp->Next;
    }

    cout << endl;
}

void ListOperations::InitializeList(List* list)
{
    list->Count = 5;
    list->Head->Data = 0;
    list->Tail->Data = 4;
    int i = 1;
    Node* temp = list->Head->Next;

    while (temp != list->Tail)
    {
        temp->Data = i;
        temp = temp->Next;
        i++;
    }

    ShowList(list);
}

void ListOperations::SortList(List* list)
{
    Node* firstNode = nullptr;
    Node* secondNode = nullptr;

    for (int i = 0; i < list->Count; i++)
    {
        firstNode = list->Head;
        secondNode = firstNode->Next;
        for (int j = i + 1; j < list->Count; j++)
        {
            if (firstNode->Data > secondNode->Data)
            {
                int temp = firstNode->Data;
                firstNode->Data = secondNode->Data;
                secondNode->Data = temp;
            }
            firstNode = firstNode->Next;
            secondNode = secondNode->Next;
        }
    }
}

void ListOperations::SearchList(List* list, int searchValue)
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
