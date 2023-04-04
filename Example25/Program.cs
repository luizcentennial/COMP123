using System;
using System.Linq;

namespace Example25 {
	class Program {
		static void Main(string[] args) {
			// LINQ:
			// A query is an instruction that retrieves data from a data source.
			// With LINQ, we can run queries against collections (i.e. arrays, lists, etc).

			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			var subset = from number in numbers
						 where number > 5
						 select number;

			foreach (int item in subset) {
				Console.Write($"{item} ");
			}

			Console.WriteLine();

			// Filter:
			// Filter functions (in C#, methods) filter out elements from
			// a given collection based on a Boolean condition.
			// The subset below includes elements for which the specified
			// Boolean expression returns true.
			subset = numbers.Where(number => number > 5);

			foreach (int item in subset) {
				Console.Write($"{item} ");
			}

			Console.WriteLine();

			// Map:
			// Mapping functions (in C#, methods), manipulate the
			// original elements in a given collection, creating a whole
			// new set with the results of the operation.
			var doubles = numbers.Select(number => number * 2);

			foreach (int item in doubles) {
				Console.Write($"{item} ");
			}

			Console.WriteLine();
		}
	}
}
