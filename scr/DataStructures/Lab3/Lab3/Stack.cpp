#include "Stack.h"
#include <iostream>

Node* Node::GetNext() const
{
    return _next;
}

void Node::SetNext(Node* next)
{
    _next = next;
}

Node::Node(int value)
{
    this->_data = value;
}

int Node::GetData() const
{
    return _data;
}

int Stack::GetSize() const
{
    return _size;
}

Node* Stack::GetLast() const
{
    return _last;
}

void Stack::Clear()
{
    while (_size > 0)
    {
        Pop();
    }
}


Node* Stack::Push(int value)
{
    auto* node = new Node(value);
    node->SetNext(_last);
    _last = node;
    _size++;
    return node;
}

int Stack::Pop()
{
    if (_size == 0)
    {
        return 0;
    }
    auto* node = _last;
    _last = _last->GetNext();
    _size--;
    int data = node->GetData();
    delete node;
    return data;
}

ostream& operator<<(ostream& os, const Stack& stack)
{
    cout << "Elements: " <<
        "\n[" << endl;
    auto* node = stack._last;
    while (node != nullptr)
    {
        cout << node->GetData();
        node = node->GetNext();
        if (node != nullptr)
        {
            cout << ", ";
        }
    }
    cout << "]\n" << endl;
    return cout;
}
