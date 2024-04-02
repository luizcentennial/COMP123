using System;
using System.Linq;

namespace Example25 {
	internal class Program {
		static void Main(string[] args)
		{
			// LINQ:
			// Language-Integrated Query (LINQ) is a tool that provides 
			// query capabilities to C# data structures.

			// Basic Functions:

			// Map:
			//
			// Mapping functions manipulate the elements in a given set, returning
			// a new set with the modified elements.
			//
			// Example: [ 1, 2, 3, 4, 5 ] -- Map (double each element) --> [ 2, 4, 6, 8, 10 ]

			// Filter:
			//
			// Filter functions remove elements from a given set based on a
			// Boolean condition.
			// The resulting subset includes elements for which the specified
			// Boolean expression returns true.
			//
			// Example: [ 1, 2, 3, 4, 5 ] -- Filter (number is even) --> [ 2, 4 ]

			// LINQ allows for two syntax styles: Query and Method.

			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// Map: Using the Query syntax.
			var subset = from number in numbers select number * 2;

			DisplayArray(numbers);
			DisplayArray(subset);

			// Map: Using the Method syntax.
			subset = numbers.Select(number => number * 2);
			DisplayArray(subset);


			// Filter: Using the Query syntax.
			subset = from number in numbers where number > 5 select number;
			DisplayArray(subset);

			// Side note: It is possible to map and filter in the same query.
			// Example:
			//subset = from number in numbers where number > 5 select number * 2;

			// Filter: Using the Method syntax.
			subset = numbers.Where(number => number > 5);
			DisplayArray(subset);
		}

		public static void DisplayArray<T>(IEnumerable<T> array)
		{
			Console.WriteLine(string.Join(", ", array));
		}
	}
}