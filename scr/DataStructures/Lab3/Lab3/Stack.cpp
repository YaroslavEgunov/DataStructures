#include "Stack.h"


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

int Stack::Peek()
{
    if (_size == 0)
    {
        return 0;
    }
    return _last->GetData();
}

void Stack::Clear()
{
    while (_size > 0)
    {
        Pop();
    }
}

int Stack::GetSize() const
{
    return _size;
}

Node* Stack::GetLast() const
{
    return _last;
}

std::ostream& operator<<(std::ostream& os, const Stack& stack)
{
    os << "=== Stack ===" << std::endl;
    os << "Size: " << stack.GetSize() << std::endl;
    os << "Last: " << stack.GetLast()->GetData() << std::endl;
    os << "Elements: " << std::endl;
    os << "[";
    auto* node = stack._last;
    while (node != nullptr)
    {
        os << node->GetData();
        node = node->GetNext();
        if (node != nullptr)
        {
            os << ", ";
        }
    }
    os << "]" << std::endl;
    return os;
}