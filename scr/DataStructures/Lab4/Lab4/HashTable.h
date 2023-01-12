#pragma once
#include <ostream>

class HashTable
{
public:
    int Size;

    int Count = 0;

    double LoadFactor = 0;

    HashTable();

    void Add(const char* key, const char* value);

    void Remove(const char* key);

    const char* Find(const char* key);

    int GetCount();

    double GetLoadFactor();

    int Hash(const char* key);

    void Rehash();

    void HashMenu();

    struct Item
    {
        char* Key;
        char* Value;
        Item* Next;
    };

    Item** Items;
};
