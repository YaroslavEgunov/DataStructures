#ifndef DATA_STRUCTURES_MENU_H
#define DATA_STRUCTURES_MENU_H
#include "BinaryTree.h"
#include "Treap.h"
using namespace std;


class Menu
{
public:
    static void BinaryTreeMenu(BinaryTree* tree);

    static void TreapMenu(Treap* treap);

    static int InputInt(const char* message);

    static int InputPositiveInt(const char* message);

    static int InputInt(const char* message, const char* regex);

    static int GetRandomInt();

    static void CheckRemove(bool check);
};


#endif //DATA_STRUCTURES_MENU_H
