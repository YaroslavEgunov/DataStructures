#define  _CRT_SECURE_NO_WARNINGS
#include <cstring>
#include <iostream>
#include "HashTable.h"
#include "Dictionary.h"
using namespace std;
double MaxLoadFactor = 0.75;

HashTable::HashTable()
{
    Size = DefaultSize;
    Items = new Item * [Size];

    for (int i = 0; i < Size; i++)
    {
        Items[i] = nullptr;
    }
}

void HashTable::Add(const char* key, const char* value)
{
    if (key == nullptr || value == nullptr)
    {
        return;
    }

    int index = Hash(key);

    if (Items[index] == nullptr)
    {
        Items[index] = new Item;
        Items[index]->Key = new char[strlen(key) + 1];
        strcpy(Items[index]->Key, key);
        Items[index]->Value = new char[strlen(value) + 1];
        strcpy(Items[index]->Value, value);
        Items[index]->Next = nullptr;
        Count++;
    }
    else
    {
        Item* item = Items[index];
        while (item->Next != nullptr)
        {
            if (strcmp(item->Key, key) == 0)
            {
                delete[] item->Value;
                item->Value = new char[strlen(value) + 1];
                strcpy(item->Value, value);

            }
            item = item->Next;
        }

        if (strcmp(item->Key, key) == 0)
        {
            delete[] item->Value;
            item->Value = new char[strlen(value) + 1];
            strcpy(item->Value, value);
        }

        item->Next = new Item;
        item->Next->Key = new char[strlen(key) + 1];
        strcpy(item->Next->Key, key);
        item->Next->Value = new char[strlen(value) + 1];
        strcpy(item->Next->Value, value);
        item->Next->Next = nullptr;
    }
    LoadFactor = Count / (double)Size;

    if (LoadFactor > MaxLoadFactor)
    {
        Rehash();
    }
    return;
}

void HashTable::Remove(const char* key)
{
    int index = Hash(key);

    if (Items[index] != nullptr)
    {
        Item* item = Items[index];

        if (strcmp(item->Key, key) == 0)
        {
            Items[index] = item->Next;
            delete item;
        }
        else
        {
            while (item->Next != nullptr)
            {
                if (strcmp(item->Next->Key, key) == 0)
                {
                    Item* temp = item->Next;
                    item->Next = item->Next->Next;
                    delete temp;
                    break;
                }
                item = item->Next;
            }
        }

        Count--;
    }
}

const char* HashTable::Find(const char* key)
{
    int index = Hash(key);

    if (Items[index] != nullptr)
    {
        Item* item = Items[index];

        while (item != nullptr)
        {
            if (strcmp(item->Key, key) == 0)
            {
                return item->Value;
            }
            item = item->Next;
        }
    }

    return nullptr;
}

int HashTable::Hash(const char* key)
{
    int hash = 0;

    for (int i = 0; i < strlen(key); i++)
    {
        hash += key[i];
    }

    return hash % Size;
}

void HashTable::Rehash()
{
    int oldSize = Size;
    Item** oldItems = Items;
    Size *= 2;
    Count = 0;
    Items = new Item * [Size];

    for (int i = 0; i < Size; i++)
    {
        Items[i] = nullptr;
    }

    for (int i = 0; i < oldSize; i++)
    {
        if (oldItems[i] != nullptr)
        {
            Item* item = oldItems[i];
            while (item != nullptr)
            {
                Add(item->Key, item->Value);
                item = item->Next;
            }
        }
    }

    for (int i = 0; i < oldSize; i++)
    {
        if (oldItems[i] != nullptr)
        {
            delete oldItems[i];
        }
    }
    delete[] oldItems;
}

void HashTable::HashMenu()
{
	cout << "Items: " << Count << "\n"
	"Load factor: " << LoadFactor << endl;

    for (int i = 0; i < Size; i++)
    {
        if (Items[i] != nullptr)
        {
            HashTable::Item* item = Items[i];
            cout << "i: " << i << endl;

            while (item != nullptr)
            {
                cout << "Key: " << item->Key << "\n" << " Value: " << item->Value << endl;
                item = item->Next;
            }
            cout << endl;
        }
    }
}

int HashTable::GetCount()
{
    return Count;
}

double HashTable::GetLoadFactor()
{
    return LoadFactor;
}
