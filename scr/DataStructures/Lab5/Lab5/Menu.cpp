#include <iostream>
#include <regex>
#include "Menu.h"

void Validate()
{
    cin.clear();
    cin.ignore(32767, '\n');
}

void Menu::BinaryTreeMenu(BinaryTree* tree)
{
    while (true)
    {
        cout << "=== Binary tree menu ===\n" 
        "1. Add node\n" 
        "2. Get height\n" 
        "3. Get min value\n" 
        "4. Get max value\n" 
        "5. Remove node\n" 
        "6. Find node\n" 
        "7. Print tree\n"
        "8. Exit" << endl;

        int choice = -1;
        cin >> choice;
        if (!cin)
        {
            Validate();
        }

        switch (choice)
        {
        case 1:
        {
            cout << "Enter value to add: " << endl;
            int value = -1;
            cin >> value;
            if (!cin)
            {
                Validate();
            }
            tree->AddNode(value);
            break;
        }
        case 2:
        {
            cout << "Height: " << tree->GetHeight() << endl;
            break;
        }
        case 3:
        {
            cout << "Min value: " << tree->GetMin() << endl;
            break;
        }
        case 4:
        {
            cout << "Max value: " << tree->GetMax() << endl;
            break;
        }
        case 5:
        {
            cout << "Enter value to remove:  " << endl;
            int value = -1;
            cin >> value;
            if (!cin)
            {
                Validate();
            }
            if (tree->Remove(value))
            {
                cout << "Node removed" << endl;
            }
            else
            {
                cout << "Node not found" << endl;
            }
        }
        case 6:
        {
            cout <<"Enter value to find: " <<endl;
            int value = -1;
            cin >> value;
            if (!cin)
            {
                Validate();
            }
            cout << "Node found: " << (tree->Find(value) ? "true" : "false") << endl;
            break;
        }
        case 7:
        {
            cout << "Tree: " << endl;
            cout << *tree << endl;
            break;
        }
        case 8:
        {
            return;
        }
        }
    }
}

void Menu::TreapMenu(Treap* treap)
{
    while (true)
    {
        cout << "=== Treap menu ===\n" 
        "1. Add node (Optimized)\n"
        "2. Add node (Non-optimized)\n" 
        "3. Remove node (Optimized)\n" 
        "4. Remove node (Non-optimized)\n" 
        "5. Find node\n" 
        "6. Get Height\n" 
        "7. Print tree\n" 
    	"8. Exit" << endl;

        int choice = -1;
        cin >> choice;
        if (!cin)
        {
            Validate();
        }
        switch (choice)
        {
        case 1:
        {
            cout << "Enter value to add: " << endl;
            int value = -1;
            cin >> value;
            if (!cin)
            {
                Validate();
            }
            treap->InsertOptimized(value,GetRandomInt());
            break;
        }
        case 2:
        {
            cout << "Enter value to add: " << endl;
            int value = -1;
            cin >> value;
            if (!cin)
            {
                Validate();
            }
            treap->InsertNonOptimized(value, GetRandomInt());
            break;
        }
        case 3:
        {
            cout << "Enter value to remove: " << endl;
            int value = -1;
            cin >> value;
            if (!cin)
            {
                Validate();
            }
            CheckRemove(treap->RemoveOptimized(value));
            break;
        }
        case 4:
        {
            cout << "Enter value to remove: " << endl;
            int value = -1;
            cin >> value;
            if (!cin)
            {
                Validate();
            }
            CheckRemove(treap->RemoveNonOptimized(value));
            break;
        }
        case 5:
        {
            int value = InputInt("Enter value to find: ");
            cout << "Node found: " << (treap->Find(value) ? "true" : "false") << endl;
            break;
        }
        case 6:
        {
            cout << "Height: " << treap->GetHeight() << endl;
            break;
        }
        case 7:
        {
            cout << "Treap: " << endl;
            cout << *treap << endl;
            break;
        }
        case 8:
        {
            return;
        }
        default:
        {
            cout << "Invalid choice" << endl;
            break;
        }
        }
    }
}

void Menu::CheckRemove(bool check)
{
    if (check)
    {
        cout << "Node removed" << endl;
    }
    else
    {
        cout << "Node not found" << endl;
    }
}

int Menu::GetRandomInt()
{
    return rand() % 100;
}
