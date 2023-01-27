using Example06.Models;
using System;

namespace Example06 {
	class Program {
		static void Main(string[] args) {
			// The line below throws an error, since constructors have been made private.
			//Person person = new Person("John", new DateTime(1985, 7, 15));

			// To instantiate Person, we must go through the CreatePerson method.
			Person person = Person.CreatePerson("John", new DateTime(1985, 7, 15));
		}
	}
}
