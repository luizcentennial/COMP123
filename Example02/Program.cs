using Example02.Models;
using System;

namespace Example02 {
	class Program {
		static void Main(string[] args) {
			Person person = new Person();
			person.Name = "John";
			person.Height = 1.85; // meters
			person.DateOfBirth = new DateTime(1985, 7, 15);

			// The line below throws an error.
			// Age is auto-calculated, therefore, cannot be set to - it's read only.
			//person.Age = 20;

			Console.WriteLine($"John's age is {person.Age}.");
		}
	}
}
