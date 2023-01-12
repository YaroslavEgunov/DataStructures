#include <string>
#include <iostream>
#include "BinaryTree.h"
#include "Treap.h"
#include "Menu.h"

int main()
{
    srand(time(nullptr));
    cout << "=== Binary tree root ===" << endl;
    auto binaryTree = new BinaryTree(Menu::InputInt("Enter root value for binary tree: "));
    cout << "=== Treap root ===" << endl;
    auto treap = new Treap(Menu::InputInt("Enter root value for treap: "),
        Menu::GetRandomInt());

    while (true)
    {
        cout << "=== Tree menu ===\n" 
        "1. Binary tree\n" 
        "2. Treap\n" 
        "3. Exit\n"
        "Enter your choice : " << endl;

        int choice = -1;
        cin >> choice;
        if (!cin)
        {
            cin.clear();
            cin.ignore(32767, '\n');
        }

        switch (choice)
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
            cout << "Invalid choice" << endl;
            break;
        }
        }
    }
}