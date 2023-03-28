using System;
using System.Collections;
using System.Collections.Generic;

namespace Example23 {
	class Program {
		static void Main(string[] args) {
			// QUEUES:
			// Queues are a data structure useful for managing collections of values
			// where the first element added is the first element to be removed.
			// This is also known as "FIFO" (first in, first out).
			// They are particularly useful in situations where elements need to be processed
			// in the order in which they are added to the queue.

			// - Queues are dynamically sized.
			// - Queues CAN BE dynamically typed (strongly-typed or loosely-typed).

			Queue<string> stronglyTypedQueue = new Queue<string>();
			Queue looselyTypedQueue = new Queue();

			// Adding to the queue:
			stronglyTypedQueue.Enqueue("First");
			stronglyTypedQueue.Enqueue("Second");

			looselyTypedQueue.Enqueue("First");
			looselyTypedQueue.Enqueue(1);
			looselyTypedQueue.Enqueue(true);

			// Removing from queue:
			string first = stronglyTypedQueue.Dequeue();

			var first2 = looselyTypedQueue.Dequeue();
		}
	}
}
