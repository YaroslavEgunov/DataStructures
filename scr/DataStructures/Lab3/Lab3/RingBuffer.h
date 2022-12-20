#ifndef DATA_STRUCTURES_RINGBUFFER_H
#define DATA_STRUCTURES_RINGBUFFER_H
#include <ostream>

class RingBuffer
{
private:
    char** _buffer;
    int _size;
    int _count;
    int _firstIndex;
    int _lastIndex;
public:
    RingBuffer(int size);
    ~RingBuffer();
    void Add(char* value);
    char* Get();
    int GetSize() const;
    int GetFreeSize() const;
    int GetCount() const;
    void Resize(int size);
    char** GetBuffer() const;
    int GetFirstIndex() const;
    int GetLastIndex() const;
    friend std::ostream& operator<<(std::ostream& os, const RingBuffer& buffer);
};


#endif //DATA_STRUCTURES_RINGBUFFER_H
