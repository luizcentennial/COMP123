using System;
using System.Collections.Generic;

namespace Example19 {
	class Program {
		static void Main(string[] args) {
			// LINKED LISTS:
			// A linked list is a data structure used to store collections of data.
			// It is made up of a series of nodes, where each node contains a data value
			// and a reference to the next node in the list.
			// Linked lists are useful for dynamic data structures because they allow for
			// efficient insertion and removal of elements to list.

			// - Linked lists are dynamically sized.
			// - Linked lists are statically typed.

			LinkedList<string> linkedList = new LinkedList<string>();

			// Adding to linked list:
			linkedList.AddFirst("First");
			linkedList.AddLast("Last");

			// Retrieving from linked list:
			string head = linkedList.First.Value;
			string tail = linkedList.Last.Value;

			var second = linkedList.First.Next; // "Next" is a reference to the second node in the linked list.
		}
	}
}
