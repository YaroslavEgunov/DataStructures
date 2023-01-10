#include <iostream>
#include "RingBufferQueue.h"
using namespace std;


RingBufferQueue::Node* RingBufferQueue::GetLast() const
{
    return _last;
}

int RingBufferQueue::GetSize() const
{
    return _size;
}

bool RingBufferQueue::IsEmpty() const
{
    return _last == nullptr;
}

RingBufferQueue::~RingBufferQueue()
{
    Clear();
}

RingBufferQueue::RingBufferQueue()
{
    _last = nullptr;
    _size = 0;
}

void RingBufferQueue::Enqueue(int value)
{
    auto* node = new Node{ value, nullptr };
    if (_last == nullptr)
    {
        node->_next = node;
    }
    else
    {
        node->_next = _last->_next;
        _last->_next = node;
    }
    _size++;
    _last = node;
}

int RingBufferQueue::Dequeue()
{
    if (_last == nullptr)
    {
        return 0;
    }
    auto* node = _last->_next;
    if (node == _last)
    {
        _last = nullptr;
    }
    else
    {
        _last->_next = node->_next;
    }
    _size--;
    int data = node->_value;
    delete node;
    return data;
}

void RingBufferQueue::Clear()
{
    if (_last == nullptr)
    {
        return;
    }
    auto* node = _last->_next;
    while (node != _last)
    {
        auto* next = node->_next;
        delete node;
        node = next;
    }
    delete node;
    _last = nullptr;
}

ostream& operator<<(std::ostream& os, const RingBufferQueue& queue)
{
    os << "=== RingBufferQueue ===" << endl;
    if (queue.GetLast() == nullptr)
    {
        os << "Queue is empty" << endl;
        return os;
    }
    auto* node = queue.GetLast()->_next;
    os << "Size: " << queue.GetSize() << endl;
    os << "Elements: ";
    os << "[";
    do
    {
        os << node->_value;
        node = node->_next;
        if (node != queue.GetLast()->_next)
        {
            os << ", ";
        }
    } while (node != queue.GetLast()->_next);
    os << "]\n" << endl;
    return os;
}
