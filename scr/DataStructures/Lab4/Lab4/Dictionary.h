#pragma once
#include "HashTable.h"
#include <string>
using namespace std;

const int DefaultSize = 10;

class Dictionary
{
public:
    Dictionary();

    string Key;

    string Value;

    void Add(const char* key, const char* value);

    void Remove(const char* key);

    const char* Find(const char* key);

    void Print();

    int GetSize();

    HashTable* Table;
};
