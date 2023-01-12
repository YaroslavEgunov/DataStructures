#ifndef DATA_STRUCTURES_BINARYTREE_H
#define DATA_STRUCTURES_BINARYTREE_H
#include <ostream>
using namespace std;

class BinaryTree
{
private:
    struct Node
    {
        int _value;
        Node* _left;
        Node* _right;
    };
    Node* _root;

    void AddNode(int value, Node* node);

    void DeleteTree(Node* node);

    int GetHeight(Node* node);

    int GetMin(Node* node);

    int GetMax(Node* node);

    Node* Find(int value, Node* node);

    Node* Remove(int value, Node* node);

    void Dump(ostream& ostream, Node* node, string prefix, bool root, bool last);

public:
    BinaryTree(int rootValue);

    ~BinaryTree();

    void AddNode(int value);

    int GetHeight();

    int GetMin();

    int GetMax();

    BinaryTree::Node* Remove(int value);

    Node* Find(int value);

    Node* GetRoot() const;

    friend ostream& operator<<(ostream& os, BinaryTree& tree);
};


#endif //DATA_STRUCTURES_BINARYTREE_H
