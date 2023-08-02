using System;
using System.Linq;

namespace Example25 {
	internal class Program {
		static void Main(string[] args) {
			// LINQ:
			// Language-Integrated Query (LINQ) is a tool that provides 
			// query capabilities to the C# language.

			// Basic Functions:
			
			// Map:
			//
			// Mapping functions manipulate the
			// original elements in a given dataset, creating a whole
			// new set with the results of the operation.
			//
			// Example: [ 1, 2, 3, 4, 5 ] --Filter--> [ 2, 4 ]

			// Filter:
			//
			// Filter functions filter out elements from
			// a given dataset based on a Boolean condition.
			// The subset below includes elements for which the specified
			// Boolean expression returns true.
			//
			// Example: [ 1, 2, 3, 4, 5 ] --Filter--> [ 2, 4 ]

			// LINQ allows for two syntax styles: Query and Method.

			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// Query Syntax: Resembles SQL queries.

			// Map:
			var subset = from number in numbers
						 select number * 2; // Map function is integrated to the query

			foreach (int number in subset) {
				Console.Write($"{number} ");
			}

			Console.WriteLine();

			// Filter:
			subset = from number in numbers
					 where number > 5 // Filter clause is integrated to the query
					 select number;

			foreach (int number in subset) {
				Console.Write($"{number} ");
			}

			Console.WriteLine();

			// Method Syntax: Concise and fluent. Uses lambda expressions.

			// Map:
			subset = numbers.Select(number => number * 2); // Maps exactly as above, but different syntax.

			foreach (int number in subset) {
				Console.Write($"{number} ");
			}

			Console.WriteLine();

			// Filter:
			subset = numbers.Where(number => number > 5); // Filters exactly as above, but different syntax.

			foreach (int number in subset) {
				Console.Write($"{number} ");
			}

			Console.WriteLine();
		}
	}
}