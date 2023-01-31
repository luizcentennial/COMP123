using Example10.Models;
using System;

namespace Example10 {
	class Program {
		static void Main(string[] args) {
			try {
				// Always executed.
				var person = Person.CreatePerson("John", new DateTime(2005, 7, 15));
				person.Height = 1.85; // m

				Console.WriteLine(person);
			}
			catch (Exception e) {
				// Executed if an error occurs.
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"An error happened. {e.Message}");
				Console.ResetColor();
			}
			finally {
				// This is optional.
				// Always executed.
				Console.WriteLine("Application ended.");
			}
		}
	}
}
