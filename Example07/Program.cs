using Example07.Models;
using System;

namespace Example07 {
	class Program {
		static void Main(string[] args) {
			// Calling a static method:
			Person person = Person.CreatePerson("John", new DateTime(1985, 07, 15));

			// Calling a non-static method:
			person.Greet();
			person.Greet("Mary");
		}
	}
}
