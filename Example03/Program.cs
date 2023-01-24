using Example03.Models;
using System;

namespace Example03 {
	class Program {
		static void Main(string[] args) {
			Person person = new Person();
			person.Name = "John";
			person.Height = 1.85; // meters

			// The age value below is acceptable...
			person.DateOfBirth = new DateTime(1985, 7, 15);

			// But the one below is not. It does not pass validation.
			person.DateOfBirth = new DateTime(2020, 7, 15);

			Console.WriteLine($"John's age is {person.Age}.");
		}
	}
}
