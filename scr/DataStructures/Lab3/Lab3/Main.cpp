#include <iostream>
#include "Stack.h"
#include "RingBuffer.h"
#include "StackQueue.h"
#include "RingBufferQueue.h"
#include "Menu.h"
using namespace std;

int main()
{
    auto* stack = new Stack();
    auto* stackQueue = new StackQueue();
    auto* ringBufferQueue = new RingBufferQueue();

    while (true)
    {
        cout << "1. Stack" << std::endl;
        cout << "2. RingBuffer" << std::endl;
        cout << "3. StackQueue" << std::endl;
        cout << "4. RingBufferQueue" << std::endl;
        cout << "5. Exit" << std::endl;
        int choice = Menu::InputPositiveInt("Enter your choice: ");
        switch (choice)
        {
        case 1:
        {
            Menu::MenuStack(stack);
            break;
        }
        case 2:
        {
            int size = Menu::InputPositiveInt("Enter buffer size: ");
            auto* buffer = new RingBuffer(size);
            Menu::MenuBuffer(buffer);
            break;
        }
        case 3:
        {
            Menu::MenuStackQueue(stackQueue);
            break;
        }
        case 4:
        {
            Menu::MenuRingBufferQueue(ringBufferQueue);
            break;
        }
        case 5:
        {
            return 0;
        }
        default:
        {
            std::cout << "Invalid choice" << std::endl;
            break;
        }
        }
    }
}

