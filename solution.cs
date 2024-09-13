Here is a JavaScript solution for reversing a singly linked list using recursion:

```javascript
function ListNode(val, next) {
    this.val = (val===undefined ? 0 : val)
    this.next = (next===undefined ? null : next)
}

function reverseList(head) {
    if (head === null || head.next === null) {
        return head;
    }
    let p = reverseList(head.next);
    head.next.next = head;
    head.next = null;
    return p;
}

// Test the function
let node3 = new ListNode(3);
let node2 = new ListNode(2, node3);
let node1 = new ListNode(1, node2);

let reversedHead = reverseList(node1);

while(reversedHead !== null) {
    console.log(reversedHead.val);
    reversedHead = reversedHead.next;
}
```

In this code, `ListNode` is a constructor function for creating a new node in the linked list. `reverseList` is a recursive function that reverses the linked list. The test at the end creates a linked list with three nodes and then reverses it, printing the values of the nodes in the reversed list to the console.