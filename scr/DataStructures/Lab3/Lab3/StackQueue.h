#ifndef DATA_STRUCTURES_STACKQUEUE_H
#define DATA_STRUCTURES_STACKQUEUE_H
#include <ostream>
#include <iostream>
#include "Stack.h"
using namespace std;

class StackQueue
{
private:
    Stack* _stackIn;
    Stack* _stackOut;
    int _size;
public:
    StackQueue();

    void Enqueue(int value);

    int Dequeue();

    void Clear();

    int GetSize() const;

    Stack* GetStackIn() const;

    Stack* GetStackOut() const;

    friend ostream& operator<<(ostream& os, const StackQueue& queue);
};


#endif //DATA_STRUCTURES_STACKQUEUE_H
