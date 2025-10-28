 

## 📖 Overview  
This project contains a collection of practical exercises designed to strengthen understanding of **Data Structures**, **Collections**, and **Algorithmic Thinking** in **C#**.  
The questions explore how to manipulate arrays, stacks, queues, and lists while applying optimization and logic-building techniques.

Each question represents a standalone exercise focusing on a specific problem-solving skill or data structure operation.

---

## 🔢 Question 01: Optimized Bubble Sort  
**Goal:**  
Improve the efficiency of the Bubble Sort algorithm by avoiding unnecessary passes when the array becomes sorted early.

**Concepts Practiced:**  
- Algorithm optimization  
- Generics with constraints (`where T : IComparable<T>`)  
- Array manipulation  

**Optimization Idea:**  
Use a boolean flag (`swapped`) to detect if any swap occurred in a pass.  
If no swaps occur → array is already sorted → stop early.

**What I Learned:**  
How to enhance time complexity from always `O(n²)` to `O(n)` in best-case scenarios by early termination.

---

## 🔄 Question 02: Reverse ArrayList In-Place  
**Goal:**  
Reverse the elements of an `ArrayList` without using the built-in `Reverse()` method.

**Concepts Practiced:**  
- Manual swapping  
- Two-pointer technique (`left`, `right`)  
- Working with `ArrayList`

**What I Learned:**  
How to manipulate collection indices directly and perform in-place updates efficiently.

---

## 📈 Question 03: Count Numbers Greater Than X  
**Goal:**  
For each query, count how many numbers in the array are greater than the given value `X`.

**Concepts Practiced:**  
- Nested loops and comparisons  
- Dynamic query input  
- Logic formulation with arrays  

**What I Learned:**  
How to handle multiple queries efficiently and compute conditional counts using loops.

---

## 🔁 Question 04: Check Palindrome Array  
**Goal:**  
Determine if a given array of integers is a palindrome.

**Concepts Practiced:**  
- Array traversal from both ends  
- Conditional checking and early exit  

**What I Learned:**  
How to compare symmetric elements and detect mirror-like array patterns.

---

## 🔄 Question 05: Reverse a Queue Using a Stack  
**Goal:**  
Reverse the order of a queue by utilizing a stack as temporary storage.

**Concepts Practiced:**  
- Queue and Stack operations  
- Enqueue / Dequeue logic  
- LIFO & FIFO concepts  

**What I Learned:**  
How data can be reversed when switching between stack (LIFO) and queue (FIFO).

---

## ⚖️ Question 06: Balanced Parentheses Checker  
**Goal:**  
Check whether a string containing parentheses `{}`, `[]`, and `()` is balanced using a stack.

**Concepts Practiced:**  
- Stack for expression validation  
- Character-by-character parsing  
- Proper pairing logic  

**What I Learned:**  
How stacks are ideal for solving matching problems like balanced brackets or syntax validation.

---

## 🚫 Question 07: Remove Duplicates from Array  
**Goal:**  
Return a new array without duplicate elements.

**Concepts Practiced:**  
- Using LINQ’s `Distinct()` method  
- Custom logic with `List.Contains()`  

**What I Learned:**  
Different approaches to removing duplicates and how to preserve unique data efficiently.

---

## 🔢 Question 08: Remove Odd Numbers from ArrayList  
**Goal:**  
Filter an `ArrayList` to keep only even numbers.

**Concepts Practiced:**  
- Typecasting and condition filtering  
- Building new lists dynamically  

**What I Learned:**  
How to perform selective filtering within non-generic collections.

---

## 🧺 Question 09: Queue with Multiple Data Types  
**Goal:**  
Implement a `Queue<object>` that stores values of different types.

**Inserted Data:**  
```csharp
queue.Enqueue(1);
queue.Enqueue("Apple");
queue.Enqueue(5.28);
Concepts Practiced:

Polymorphism with object
Generic data handling

What I Learned:

How to design flexible collections that can store heterogeneous types.

🎯 Question 10: Stack Search with Target Input

Goal:
Push a series of integers onto a stack, then search for a target integer.
Report if found and how many elements were checked.

Concepts Practiced:
Iterating through a stack
Search logic with counters
User input processing

What I Learned:
Practical stack traversal and counting iterations before reaching a target.

🔗 Question 11: Find Intersection of Two Arrays

Goal:
Find common elements between two arrays. Each element appears in the result as many times as it appears in both arrays.

Concepts Practiced:
Nested looping
Matching and marking duplicates
List usage for dynamic storage

What I Learned:
How to compute intersection manually without relying on built-in set operations.

➕ Question 12: Find Contiguous Sublist with Target Sum

Goal:
Given an ArrayList and a target sum, find a continuous sublist whose sum equals the target.

Concepts Practiced:
Subarray sum logic
Sliding window (optional improvement idea)
Iterative summation

What I Learned:
Understanding how contiguous sublists can be identified by iterating through cumulative sums.

🔁 Question 13: Reverse First K Elements of a Queue

Goal:
Reverse only the first K elements of a queue, keeping the rest unchanged.

Concepts Practiced:
Stack + Queue hybrid logic
Order preservation techniques

What I Learned:
How to manipulate partial collections while maintaining overall sequence integrity.

⚙️ How to Run

Open the solution in Visual Studio.
Select C_Advanced_A2 project.
Build and run using Ctrl + F5.
Follow console prompts to test each question independently by uncommenting its region in Program.cs.

🧠 Key Takeaways

Strengthened understanding of Stacks, Queues, ArrayLists, and Arrays.
Practiced generic programming and collection manipulation.
Applied logical thinking and optimization techniques to real problems.
Learned how C# data structures behave under various algorithmic scenarios.

👨‍💻 Author

Abdalla Adel Aboaziz
Backend Developer (.NET)
