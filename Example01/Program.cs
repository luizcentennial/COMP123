using System;
using Example01.Models;

namespace Example01 {
	class Program {
		static void Main(string[] args) {
			// Instantiating the class
			Person person = new Person();

			// Initializing properties
			person.Name = "John";
			person.Height = 1.85; // meters
			person.DateOfBirth = new DateTime(1985, 7, 15);

			// Retrieving property values
			Console.WriteLine("Person object successfully created!");
			Console.WriteLine($"Name: {person.Name}");
			Console.WriteLine($"Height: {person.Height} m");
			Console.WriteLine($"Date of birth: {person.DateOfBirth:MM-dd-yyyy}");
		}
	}
}
