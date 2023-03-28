using System;
using System.Collections.Generic;

namespace Example20 {
	class Program {
		static void Main(string[] args) {
			// LISTS:
			// Lists are used when there is a need for an
			// array-like data structure that is able to dynamically
			// resize itself as needed and is strongly-typed.

			// - Lists are dynamically sized.
			// - Lists are statically typed.
			List<string> list = new List<string>(); // Size = 0.

			// Adding to list:
			list.Add("First"); // Size = 1.
			list.Add("Last"); // Size = 2.

			// Retrieving from list:
			string value = list[0];
		}
	}
}
