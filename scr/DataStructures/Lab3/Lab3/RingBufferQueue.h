#ifndef DATA_STRUCTURES_RINGBUFFERQUEUE_H
#define DATA_STRUCTURES_RINGBUFFERQUEUE_H
#include <ostream>
#include "RingBuffer.h"
using namespace std;

class RingBufferQueue
{
private:
    struct Node
    {
        int _value;
        Node* _next;
    };
    Node* _last;

    int _size;
public:

    RingBufferQueue();

    ~RingBufferQueue();

    void Enqueue(int value);

    int Dequeue();

    int GetSize() const;

    bool IsEmpty() const;

    void Clear();

    Node* GetLast() const;

    friend ostream& operator<<(ostream& os, const RingBufferQueue& queue);
};


#endif //DATA_STRUCTURES_RINGBUFFERQUEUE_H
