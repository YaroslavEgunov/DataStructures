#include <iostream>
#include "Dictionary.h"

Dictionary::Dictionary()
{
    Table = new HashTable;
}

void Dictionary::Add(const char* key, const char* value)
{
    if (Find(key) != nullptr)
    {
        return;
    }
    Table->Add(key, value);
    return;
}

void Dictionary::Remove(const char* key)
{
    Table->Remove(key);
}

const char* Dictionary::Find(const char* key)
{
    return Table->Find(key);
}

int Dictionary::GetSize()
{
    return Table->Size;
}


void Dictionary::Print()
{
	cout << "Size: " << GetSize() << endl;
    Table->HashMenu();
}