using Example05.Models;
using System;

namespace Example05 {
	class Program {
		static void Main(string[] args) {			
			// The Person class can now be instantiated in 3 different ways.
			Person person1 = new Person();
			Person person2 = new Person("John");
			Person person3 = new Person("John", new DateTime(1985, 7, 15));
		}
	}
}
