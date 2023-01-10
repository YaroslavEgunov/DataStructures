#include <iostream>
#include <regex>
#include "Stack.h"
#include "StackQueue.h"
#include "RingBuffer.h"
#include "RingBufferQueue.h"
#include "Menu.h"
using namespace std;

void Validate()
{
	cin.clear();
	cin.ignore(32767, '\n');
}


void Menu::MenuRingBufferQueue(RingBufferQueue* queue)
{
    while (true)
    {
        cout << " --- Ring buffer queue menu --- \n"
        "1. Enqueue\n" 
        "2. Dequeue\n" 
        "3. Get size\n" 
        "4. Is empty\n"
        "5. Print\n" 
    	"6. Back\n"
    	"Enter key : " <<endl;

        int key = -1;
    	cin >> key;
        if (!cin)
        {
			Validate();
		}

        switch (key)
        {
	        case 1:
	        {
	            cout << "Enter _value: " << endl;
	            int value = -1;
	            cin >> value;
	            if (!cin)
	            {
	                cin.clear();
	                cin.ignore(32767, '\n');
	            }
	            queue->Enqueue(value);
	            break;
	        }
	        case 2:
	        {
	            int value = queue->Dequeue();
	            if (value == 0)
	            {
	                cout << "Queue is empty" << endl;
	            }
	            else
	            {
	                cout << "Dequeued _value: " << value << endl;
	            }
	            break;
	        }
	        case 3:
	        {
	            cout << "Size: " << queue->GetSize() << endl;
	            break;
	        }
	        case 4:
	        {
	            cout << "Is empty: " << (queue->IsEmpty() ? "true" : "false") << endl;
	            break;
	        }
	        case 5:
	        {
	            cout << *queue << endl;
	            break;
	        }
	        case 6:
	        {
	            return;
	        }
	        default:
	        {
	            cout << "Invalid value\n" << endl;
	            break;
	        }
        }
    }
}

void Menu::MenuStackQueue(StackQueue* queue)
{
    while (true)
    {
        cout << " --- Stack queue menu --- \n"
        "1. Enqueue\n" 
        "2. Dequeue\n"
        "3. Get size\n" 
        "4. Print\n" 
        "5. Exit\n" 
    	"Enter key : " << endl;

        int key = -1;
        cin >> key;
		if (!cin)
		{
			Validate();
		}

        switch (key)
        {
	        case 1:
	        {
	            cout << "Enter value: " << endl;
	            int value = -1;
	            cin >> value;
	            if (!cin)
	            {
	                cin.clear();
	                cin.ignore(32767, '\n');
	            }
	            queue->Enqueue(value);
	            break;
	        }
	        case 2:
	        {
	            int value = queue->Dequeue();
	            if (value == 0)
	            {
	                cout << "Queue is empty" << endl;
	            }
	            else
	            {
	                cout << "Dequeued value: " << value << endl;
	            }
	            break;
	        }
	        case 3:
	        {
	            cout << "Size: " << queue->GetSize() << endl;
	            break;
	        }
	        case 4:
	        {
	            cout << *queue << endl;
	            break;
	        }
	        case 5:
	        {
	            return;
	        }
	        default:
	        {
	            cout << "Invalid value\n" << endl;
	            break;
	        }
        }
    }
}

void Menu::MenuBuffer(RingBuffer* buffer)
{
    while (true)
    {
        std::cout << " --- Buffer menu --- \n"
        "1. Resize buffer\n"
        "2. Add element\n" 
        "3. Get element\n" 
        "4. Get size\n" 
        "5. Print\n" 
    	"6. Exit\n"
        "Enter key : " << endl;

        int key = -1;
        cin >> key;
		if (!cin)
		{
			Validate();
		}

        switch (key)
        {
	        case 1:
	        {
	            cout << "Enter new size: " << endl;
	            int size = -1;
	            cin >> size;
	            if (!cin)
	            {
	                cin.clear();
	                cin.ignore(32767, '\n');
	            }
	            if (size < buffer->GetSize())
	            {
	                cout << "New size is less than current size" << endl;
	                break;
	            }
	            buffer->Resize(size);
	            break;
	        }
	        case 2:
	        {
	            char* value = new char[256];
	            cout << "Enter _value: ";
	            cin >> value;
	            buffer->Add(value);
	            break;
	        }
	        case 3:
	        {
	            char* get = buffer->Get();
	            if (get == nullptr)
	            {
	                cout << "Buffer is empty" << endl;
	            }
	            else
	            {
	                cout << "Get _value: " << get << endl;
	            }
	            break;
	        }
	        case 4:
	        {
	            cout << "Size: " << buffer->GetSize() << endl;
	            break;
	        }
	        case 5:
	        {
	            cout << *buffer << endl;
	            break;
	        }
	        case 6:
	        {
	            return;
	        }
	        default:
	        {
	            cout << "Invalid value\n" << endl;
	            break;
	        }
        }
    }
}

void Menu::MenuStack(Stack* stack)
{
    while (true)
    {
        cout << " --- Stack menu --- \n"
        "1. Push\n" 
        "2. Pop\n" 
        "3. Clear\n" 
        "4. Print\n" 
        "5. Back\n"
        "Enter key : " << endl;

        int key = -1;
        cin >> key;
		if (!cin)
		{
			Validate();
		}

        switch (key)
        {
	        case 1:
	        {
	            cout << "Enter value: " << endl;
	            int value = -1;
	            cin >> value;
	            if (!cin)
	            {
	                cin.clear();
	                cin.ignore(32767, '\n');
	            }
	            stack->Push(value);
	            break;
	        }
	        case 2:
	        {
	            int value = stack->Pop();
	            if (value == 0)
	            {
	                cout << "Stack is empty" << endl;
	            }
	            else
	            {
	                cout << "Popped value: " << value << endl;
	            }
	            break;
	        }
	        case 3:
	        {
	            stack->Clear();
	            break;
	        }
	        case 4:
	        {
	            cout << *stack << endl;
	            break;
	        }
	        case 5:
	        {
	            return;
	        }
	        default:
	        {
	           cout << "Invalid value\n" << endl;
	            break;
	        }
        }
    }
}