using System;

namespace Example18 {
	class Program {
		static void Main(string[] args) {
			// ARRAYS:
			// Arrays are a data structure used to store a collection of elements
			// of the same data type. An array is a contiguous block of memory in
			// which each element is stored at a specific index or position.

			// - Arrays are statically sized.
			// - Arrays are statically typed.

			// Declaring and initializing an array:
			string[] array = { "Hello", "World!" };

			// Alternatively:

			int[] numbers = new int[5]; // Size = 5.
			numbers[0] = 1;
			numbers[0] = 2;
			numbers[0] = 3;
			numbers[0] = 4;
			numbers[0] = 5;
		}
	}
}
