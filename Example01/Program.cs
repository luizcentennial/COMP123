using System;
using Example01.Models;

namespace Example01 {
	class Program {
		static void Main(string[] args) {
			// Syntax for "simple" types:
			string text = "This is a text";
			int[] numbers = new int[5];

			// Syntax for classes:
			Person person = new Person();
			person.Name = "John";
			person.Height = 1.85; // meters
			person.DateOfBirth = new DateTime(1985, 7, 15);
		}
	}
}
