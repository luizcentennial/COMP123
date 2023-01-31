using Example08.Models;
using System;

namespace Example08 {
	class Program {
		static void Main(string[] args) {
			var person = Person.CreatePerson("John", new DateTime(1985, 7, 15));

			// The line below throws an error.
			// DateOfBirth property is private set.
			//person.DateOfBirth = new DateTime(2000, 7, 15);
		}
	}
}
