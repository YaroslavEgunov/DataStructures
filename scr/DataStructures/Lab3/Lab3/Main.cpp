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
		cout << " --- Main menu --- \n"
			"1. Stack\n"
			"2. RingBuffer\n"
			"3. StackQueue\n"
			"4. RingBufferQueue\n"
			"5. Exit\n"
			"Enter key :" << endl;
		int key = -1;
		cin >> key;

		if (!cin)
		{
			cin.clear();
			cin.ignore(32767, '\n');
		}

        switch (key)
        {
	        case 1:
	        {
	            Menu::MenuStack(stack);
	            break;
	        }
	        case 2:
	        {
				cout << "Enter buffer size: " << endl;
	            int size = -1;
				cin >> size;

				if (!cin)
				{
					cin.clear();
					cin.ignore(32767, '\n');
				}

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
	            cout << "Invalid value\n" << endl;
	            break;
	        }
        }
    }
}
