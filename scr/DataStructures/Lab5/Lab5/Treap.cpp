#include "Treap.h"
#include <iostream>
#include <ostream>


Treap::~Treap()
{
    DeleteTree(_root);
}

int Treap::GetHeight()
{
    return GetHeight(_root);
}

Treap::Treap(int rootValue, int rootPriority)
{
    _root = new Node{ rootValue, rootPriority, nullptr, nullptr };
}

Treap::Node* Treap::RemoveNonOptimized(int value)
{
    return RemoveNonOptimized(value, _root);
}

Treap::Node* Treap::Find(int value)
{
    return Find(value, _root);
}

Treap::Node* Treap::RemoveOptimized(int value)
{
    return RemoveOptimized(value, _root);
}

std::ostream& operator<<(std::ostream& os, Treap& treap)
{

    treap.Dump(os, treap._root, "", false, false);
    return os;
}

void Treap::DeleteTree(Treap::Node* node)
{
    if (node != nullptr)
    {
        DeleteTree(node->_left);
        DeleteTree(node->_right);
        delete node;
    }
}

int Treap::GetHeight(Treap::Node* node)
{
    if (node == nullptr)
    {
        return 0;
    }
    int leftHeight = GetHeight(node->_left);
    int rightHeight = GetHeight(node->_right);
    return 1 + (leftHeight > rightHeight ? leftHeight : rightHeight);
}

void Treap::InsertNonOptimized(int value, int priority)
{
    if (_root == nullptr)
    {
        _root = new Node{ value, priority, nullptr, nullptr };
    }
    else
    {
        InsertNonOptimized(value, priority, _root);
    }
}

void Treap::InsertOptimized(int value, int priority)
{
    if (_root == nullptr)
    {
        _root = new Node{ value, priority, nullptr, nullptr };
    }
    else
    {
        InsertOptimized(value, priority, _root);
    }
}

void Treap::Split(Treap::Node* node, int key, Treap::Node*& left, Treap::Node*& right)
{
    if (node == nullptr)
    {
        left = nullptr;
        right = nullptr;
    }
    else
    {
        if (key < node->_value)
        {
            Split(node->_left, key, left, node->_left);
            right = node;
        }
        else
        {
            Split(node->_right, key, node->_right, right);
            left = node;
        }
    }
}

Treap::Node*& Treap::Merge(Treap::Node*& left, Treap::Node*& right)
{
    if (left == nullptr)
    {
        return right;
    }
    else
    {
        if (right == nullptr)
        {
            return left;
        }
        else
        {
            if (left->_priority > right->_priority)
            {
                left->_right = Merge(left->_right, right);
                return left;
            }
            else
            {
                right->_left = Merge(left, right->_left);
                return right;
            }
        }
    }
}

Treap::Node* Treap::Find(int value, Treap::Node* node)
{
    if (node == nullptr)
    {
        return nullptr;
    }
    if (value == node->_value)
    {
        return node;
    }
    if (value < node->_value)
    {
        return Find(value, node->_left);
    }
    else
    {
        return Find(value, node->_right);
    }
}

void Treap::InsertNonOptimized(int value, int priority, Treap::Node*& node)
{
    if (node == nullptr)
    {
        node = new Node{ value, priority, nullptr, nullptr };
    }
    else
    {
        if (priority > node->_priority)
        {
            Node* newNode = new Node{ value, priority, nullptr, nullptr };
            Node* left = nullptr;
            Node* right = nullptr;
            Split(node, value, left, right);
            node = Merge(Merge(left, newNode), right);
        }
        else
        {
            if (value < node->_value)
            {
                InsertNonOptimized(value, priority, node->_left);
            }
            else
            {
                InsertNonOptimized(value, priority, node->_right);
            }
        }
    }
}

void Treap::InsertOptimized(int value, int priority, Treap::Node*& node)
{
    if (node == nullptr)
    {
        node = new Node{ value, priority, nullptr, nullptr };
    }
    else
    {
        if (priority > node->_priority)
        {
            Node* left = nullptr;
            Node* right = nullptr;
            Split(node, value, left, right);
            node = new Node{ value, priority, left, right };
        }
        else
        {
            if (value < node->_value)
            {
                InsertOptimized(value, priority, node->_left);
            }
            else
            {
                InsertOptimized(value, priority, node->_right);
            }
        }
    }
}

Treap::Node* Treap::RemoveNonOptimized(int value, Treap::Node*& node)
{
    if (node == nullptr)
    {
        return nullptr;
    }
    if (value == node->_value)
    {
        Node* left = nullptr;
        Node* right = nullptr;
        Split(node, value, left, right);
        Node* temp = nullptr;
        Split(right, value + 1, temp, right);
        delete temp;
        node = Merge(left, right);
    }
    if (value < node->_value)
    {
        return RemoveNonOptimized(value, node->_left);
    }
    else
    {
        return RemoveNonOptimized(value, node->_right);
    }
    return node;
}

Treap::Node* Treap::RemoveOptimized(int value, Treap::Node*& node)
{
    if (node == nullptr)
    {
        return nullptr;
    }
    if (value == node->_value)
    {
        Node* temp = node;
        node = Merge(node->_left, node->_right);
        delete temp;
    }
    else
    {
        if (value < node->_value)
        {
            RemoveOptimized(value, node->_left);
        }
        else
        {
            RemoveOptimized(value, node->_right);
        }
    }
    return node;
}


void Treap::Dump(ostream& cout, Treap::Node* node, string prefix = "", bool root = true, bool last = true)
{
    if (node != nullptr)
    {
        cout << prefix;
        if (root)
        {
            cout << "\\-";
        }
        else
        {
            if (last)
            {
                cout << "\\-";
                prefix += "  ";
            }
            else
            {
                cout << "|-";
                prefix += "|  ";
            }
        }
        cout << "(v=" << node->_value << ", p=" << node->_priority << ")" << endl;
        Dump(cout, node->_left, prefix, false, false);
        Dump(cout, node->_right, prefix, false, true);
    }
}
