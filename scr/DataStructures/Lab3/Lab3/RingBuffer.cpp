#include <iostream>
#include "RingBuffer.h"

RingBuffer::~RingBuffer()
{
    delete[] _buffer;
}

char** RingBuffer::GetBuffer() const
{
    return _buffer;
}

int RingBuffer::GetFirstIndex() const
{
    return _firstIndex;
}

int RingBuffer::GetLastIndex() const
{
    return _lastIndex;
}

int RingBuffer::GetSize() const
{
    return _size;
}

int RingBuffer::GetFreeSize() const
{
    return _size - _count;
}

int RingBuffer::GetCount() const
{
    return _count;
}

RingBuffer::RingBuffer(int size)
{
    _firstIndex = 0;
    _lastIndex = 0;
    _count = 0;
    _size = size;
    _buffer = new char* [_size];
    for (int i = 0; i < _size; i++)
    {
        _buffer[i] = nullptr;
    }
}

void RingBuffer::Add(char* value)
{
    if (_count == _size)
    {
        _buffer[_firstIndex] = value;
        _firstIndex = (_firstIndex + 1) % _size;
        _lastIndex = (_lastIndex + 1) % _size;
        return;
    }
    _buffer[_lastIndex] = value;
    _lastIndex = (_lastIndex + 1) % _size;
    _count++;
}

char* RingBuffer::Get()
{
    if (_count == 0)
    {
        return nullptr;
    }
    char* value = _buffer[_firstIndex];
    _buffer[_firstIndex] = nullptr;
    _firstIndex = (_firstIndex + 1) % _size;
    _count--;
    return value;
}

void RingBuffer::Resize(int size)
{
    if (size < _count)
    {
        return;
    }
    char** newBuffer = new char* [size];
    for (int i = 0; i < size; i++)
    {
        newBuffer[i] = nullptr;
    }
    for (int i = 0; i < _count; i++)
    {
        newBuffer[i] = _buffer[(_firstIndex + i) % _size];
    }
    delete[] _buffer;
    _buffer = newBuffer;
    _size = size;
    _firstIndex = 0;
    _lastIndex = _count;
}

ostream& operator<<(ostream& os, const RingBuffer& buffer)
{
    cout << "Size: " << buffer.GetSize() << 
        "\nCount: " << buffer.GetCount() << 
        "\nFree size: " << buffer.GetFreeSize() << 
        "\nBuffer: "
		"[" << endl;
    for (int i = 0; i < buffer.GetSize(); i++)
    {
        if (buffer.GetBuffer()[i] == nullptr)
        {
            cout << "null";
        }
        else
        {
            cout << buffer.GetBuffer()[i];
        }
        if (i != buffer.GetSize() - 1)
        {
            cout << ", ";
        }
    }
    cout << "]\n" << endl;
    cout << endl;
    return cout;
}

