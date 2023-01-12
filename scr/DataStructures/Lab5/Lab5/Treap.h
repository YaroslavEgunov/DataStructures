#ifndef DATA_STRUCTURES_TREAP_H
#define DATA_STRUCTURES_TREAP_H
#include <ostream>
using namespace std;

class Treap
{
private:

    const string ch_hor = "\u2500" /*─*/;
    const string ch_ver = "\u2502" /*│*/;
    const string ch_ddia = "\u250C" /*┌*/;
    const string ch_rddia = "\u2510" /*┐*/;
    const string ch_udia = "\u2514" /*└*/;
    const string ch_ver_hor = "\u251C\u2500" /*├─*/;
    const string ch_udia_hor = "\u2514\u2500" /*└─*/;
    const string ch_ddia_hor = "\u250C\u2500" /*┌─*/;
    const string ch_ver_spa = "\u2502 " /*│ */;

    struct Node
    {
        int _value;

        int _priority;

        Node* _left;

        Node* _right;
    };
    Node* _root;

    void InsertNonOptimized(int value, int priority, Node*& node);

    void InsertOptimized(int value, int priority, Node*& node);

    Treap::Node* RemoveNonOptimized(int value, Node*& node);

    Treap::Node* RemoveOptimized(int value, Node*& node);

    void Split(Node* node, int key, Node*& left, Node*& right);

    Node*& Merge(Node*& left, Node*& right);

    Node* Find(int value, Node* node);

    int GetHeight(Node* node);

    void DeleteTree(Node* node);

    void Dump(std::ostream& ostream, Node* node, std::string prefix, bool root, bool last);

public:

    Treap(int rootValue, int rootPriority);

    ~Treap();

    void InsertNonOptimized(int value, int priority);

    void InsertOptimized(int value, int priority);

    Node* RemoveNonOptimized(int value);

    Node* RemoveOptimized(int value);

    int GetHeight();

    Node* Find(int value);

    friend ostream& operator<<(ostream& os, Treap& treap);
};


#endif //DATA_STRUCTURES_TREAP_H
