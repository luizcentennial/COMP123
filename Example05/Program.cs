using Example05.Models;
using System;

namespace Example05 {
	class Program {
		static void Main(string[] args) {
			Person person = new Person("John", new DateTime(1985, 7, 15)); // <-- This is a constructor call.
			person.Height = 1.85; // meters
		}
	}
}
