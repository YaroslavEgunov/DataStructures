#ifndef DATA_STRUCTURES_STACK_H
#define DATA_STRUCTURES_STACK_H
#include <ostream>

class Node
{
private:
    int _data;
    Node* _next{};
public:
    int GetData() const;
    Node* GetNext() const;
    void SetNext(Node* next);
    Node(int value);
};

class Stack
{
private:
    Node* _last;
    int _size;
public:
    Node* Push(int value);
    int Pop();
    int Peek();
    void Clear();
    int GetSize() const;
    Node* GetLast() const;
    friend std::ostream& operator<<(std::ostream& os, const Stack& stack);
};


#endif //DATA_STRUCTURES_STACK_H
