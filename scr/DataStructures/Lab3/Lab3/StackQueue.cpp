#include <iostream>
#include "StackQueue.h"
using namespace std;

int StackQueue::GetSize() const
{
    return _size;
}

Stack* StackQueue::GetStackIn() const
{
    return _stackIn;
}

Stack* StackQueue::GetStackOut() const
{
    return _stackOut;
}

void StackQueue::Enqueue(int value)
{
    _stackIn->Push(value);
    _size++;
}

StackQueue::StackQueue()
{
    _stackIn = new Stack();
    _stackOut = new Stack();
    _size = 0;
}

int StackQueue::Dequeue()
{
    if (_size == 0)
    {
        return 0;
    }

    if (_stackOut->GetSize() == 0)
    {
        while (_stackIn->GetSize() > 0)
        {
            _stackOut->Push(_stackIn->Pop());
        }
    }
    _size--;
    return _stackOut->Pop();
}

ostream& operator<<(ostream& os, const StackQueue& queue)
{
    cout << "StackIn: " << *queue.GetStackIn() << 
        "\nStackOut: " << *queue.GetStackOut() << endl;
    return cout;
}
