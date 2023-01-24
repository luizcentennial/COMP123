using Example04.Models;
using System;

namespace Example04 {
	class Program {
		static void Main(string[] args) {
			Person person = new Person(); // <-- This is a constructor call.
			person.Name = "John";
			person.Height = 1.85; // meters
			person.DateOfBirth = new DateTime(1985, 7, 15);
		}
	}
}
