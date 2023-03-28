using System;
using System.Collections;

namespace Example21 {
	class Program {
		static void Main(string[] args) {
			// ARRAY LISTS:
			// Array lists are used when there is a need for an
			// array-like data structure that is able to dynamically
			// resize itself as needed and is loosely-typed.

			// - Array lists are dynamically sized.
			// - Array lists are dynamically typed.

			ArrayList arrayList = new ArrayList(); // Size = 0.
			
			// Adding to array list:
			arrayList.Add("Hello, World!"); // Size = 1.
			arrayList.Add(15); // Size = 2.
			arrayList.Add(true); // Size = 3.

			// Referencing items in array list:
			var item = arrayList[0];
		}
	}
}
