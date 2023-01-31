using Example09.Models;
using System;

namespace Example09 {
	class Program {
		static void Main(string[] args) {
			var person = Person.CreatePerson("John", new DateTime(1985, 7, 15));
			person.Height = 1.85; // m

			Console.WriteLine(person);
		}
	}
}
