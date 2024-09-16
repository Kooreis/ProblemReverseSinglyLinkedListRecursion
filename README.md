# Question: How do you reverse a singly linked list using recursion? JavaScript Summary

The provided JavaScript code defines a solution for reversing a singly linked list using recursion. The `ListNode` function is a constructor that creates a new node with a value and a reference to the next node. The `reverseList` function is the recursive function that performs the reversal of the linked list. It checks if the head of the list is null or if the next node is null, in which case it returns the head, effectively marking the end of the recursion. If not, it recursively calls itself with the next node, and then modifies the current node's next node's next pointer to point back to the current node, effectively reversing the link. It then sets the current node's next pointer to null, to end the list. The test code at the end creates a linked list with three nodes, reverses it using the `reverseList` function, and then iterates through the reversed list, printing each node's value to the console.

---

# TypeScript Differences

The TypeScript version of the solution solves the problem in a similar way to the JavaScript version. Both versions use recursion to reverse the linked list. The main difference between the two versions is that the TypeScript version uses TypeScript's static typing features to provide type annotations for the `ListNode` class and the `reverseList` function.

In the TypeScript version, `ListNode` is a class with two properties: `val` and `next`. The `val` property is a number and the `next` property is either another `ListNode` or `null`. The constructor for `ListNode` takes two optional parameters, `val` and `next`, and assigns them to the `val` and `next` properties of the instance. If `val` or `next` are not provided, they default to `0` and `null`, respectively.

The `reverseList` function in the TypeScript version takes a `ListNode` or `null` as a parameter and returns a `ListNode` or `null`. This function works the same way as the JavaScript version, but with the added benefit of TypeScript's static typing.

The test at the end of the TypeScript version creates a linked list with five nodes and then reverses it, printing the values of the nodes in the reversed list to the console. This is done in a similar way to the JavaScript version, but with the addition of type annotations.

In summary, the TypeScript version of the solution uses TypeScript's static typing features to provide type safety and make the code more self-documenting. The logic of the solution is the same in both versions.

---

# C++ Differences

The C++ version of the solution uses a similar approach to the JavaScript version, but there are some differences due to the language features and syntax of C++.

1. Data Structure: In C++, a struct is used to define the linked list node, while in JavaScript, a constructor function is used. The struct in C++ is a simple data structure that can hold different types of data, in this case, an integer and a pointer to the next node. The constructor function in JavaScript is a special type of function used to initialize new objects.

2. Memory Allocation: In C++, memory for new nodes is allocated using the `new` keyword, which returns a pointer to the memory. In JavaScript, memory is automatically managed, and new objects are created using the `new` keyword.

3. Null Checking: Both versions check if the next node is null to determine the base case for the recursion. However, in C++, the null check is done using the `==` operator, while in JavaScript, the `===` operator is used for strict equality checking.

4. Insertion: In the C++ version, an `insert` function is used to add new nodes at the beginning of the list. In the JavaScript version, new nodes are added by passing the next node as an argument to the `ListNode` constructor.

5. Printing: In the C++ version, the `print` function uses the `std::cout` object to print the data of each node. In JavaScript, `console.log` is used for printing.

6. Global Variable: In the C++, the `head` of the linked list is a global variable, which is not a common practice in JavaScript.

7. Main Function: In C++, the `main` function is the entry point of the program, where nodes are inserted, the list is printed, reversed, and printed again. In JavaScript, there is no main function, and the code is executed sequentially from top to bottom.

---
