```cpp
#include <iostream>

struct Node {
    int data;
    Node* next;
};

Node* head = NULL;

void insert(int value) {
    Node* temp = new Node();
    temp->data = value;
    temp->next = head;
    head = temp;
}

void print(Node* p) {
    if (p == NULL) return;
    std::cout << p->data << " ";
    print(p->next);
}

Node* reverse(Node* p) {
    if (p->next == NULL) {
        head = p;
        return p;
    }
    Node* temp = reverse(p->next);
    temp->next = p;
    p->next = NULL;
    return p;
}

int main() {
    insert(5);
    insert(4);
    insert(3);
    insert(2);
    insert(1);
    print(head);
    std::cout << "\n";
    reverse(head);
    print(head);
    return 0;
}
```