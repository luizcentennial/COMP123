using System;
using System.Collections;
using System.Collections.Generic;

namespace Example22 {
	class Program {
		static void Main(string[] args) {
			// STACKS:
			// Stacks are a data structure useful for managing collections of values
			// where the first element added is the last element to be removed.
			// This is also known as "FILO" (first in, last out), or "LIFO" (last in, first out).
			// They are particularly useful in situations where elements need to be processed
			// in reverse order, compared to the order in which they were added to the stack.

			// - Stacks are dynamically sized.
			// - Stacks CAN BE dynamically typed (strongly-typed, or loosely-typed).

			Stack<int> stronglyTypedStack = new Stack<int>(); // Size = 0.
			Stack looselyTypedStack = new Stack(); // Size = 0.

			// Adding to stack:
			stronglyTypedStack.Push(1); // Size is 1.
			stronglyTypedStack.Push(2); // Size is 2.
			stronglyTypedStack.Push(3); // Size is 3.

			looselyTypedStack.Push("Hello"); // Size = 1.
			looselyTypedStack.Push(1); // Size = 2.
			looselyTypedStack.Push(false); // Size = 3.

			// Removing from stack:
			int last = stronglyTypedStack.Pop(); // Size is 2.

			var last2 = looselyTypedStack.Pop(); // Size = 2.
		}
	}
}
