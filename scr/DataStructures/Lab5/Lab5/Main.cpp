#include <string>
#include <iostream>
#include "BinaryTree.h"
#include "Treap.h"
#include "Menu.h"

int main()
{
    srand(time(nullptr));
    cout << "--- Binary tree root ---" << endl;
    int BinaryRootValue = -1;
    cin >> BinaryRootValue;
    if (!cin)
    {
        cin.clear();
        cin.ignore(32767, '\n');
    }
    auto binaryTree = new BinaryTree(BinaryRootValue);
    cout << "--- Treap root ---" << endl;
    cout << "Enter root value for treap: " << endl;
    int TreapRootValue = -1;
    cin >> TreapRootValue;
    if (!cin)
    {
        cin.clear();
        cin.ignore(32767, '\n');
    }
    auto treap = new Treap(TreapRootValue,Menu::GetRandomInt());

    while (true)
    {
        cout << "--- Tree menu ---\n" 
        "1. Binary tree\n" 
        "2. Treap\n" 
        "3. Exit\n"
        "Enter your choice : " << endl;

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
            Menu::BinaryTreeMenu(binaryTree);
            break;
        }
        case 2:
        {
            Menu::TreapMenu(treap);
            break;
        }
        case 3:
        {
            return 0;
        }
        default:
        {
            cout << "Invalid key" << endl;
            break;
        }
        }
    }
}