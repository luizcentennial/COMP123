using Example07.Models;
using System;

namespace Example07 {
	class Program {
		static void Main(string[] args) {
			Person person = Person.CreatePerson("John", new DateTime(1985, 7, 15));
			person.Height = 1.85; // meters

			person.Greet();
			person.Greet("Mary");
		}
	}
}
