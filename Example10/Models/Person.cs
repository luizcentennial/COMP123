using System;

namespace Example10.Models {
	public class Person {
		// Fields
		private DateTime _dateOfBirth;

		// Properties
		public string Name { get; set; }
		public double Height { get; set; }
		public DateTime DateOfBirth {
			get {
				return this._dateOfBirth;
			}
			private set {
				if (value.Year < 2000) {
					this._dateOfBirth = value;
				}
				else {
					throw new Exception("Error: Age value not accepted. When creating instances of Person, make sure to follow age acceptance rules.");
				}
			}
		}
		public int Age {
			get {
				int age = DateTime.Now.Year - this.DateOfBirth.Year;

				if (DateTime.Now.DayOfYear < this.DateOfBirth.DayOfYear) {
					age--;
				}

				return age;
			}
		}

		// Constructors
		private Person() {
			this.Name = "Untitled";
		}

		private Person(string name) {
			this.Name = name;
		}

		private Person(string name, DateTime dob) : this(name) {
			this.DateOfBirth = dob;
		}

		// Methods
		public static Person CreatePerson(string name, DateTime dob) {
			Person person = new Person(name, dob);

			return person;
		}

		public void Greet() {
			Console.WriteLine("Hello!"); // <-- No no no.
		}

		public void Greet(string name) {
			Console.WriteLine($"Hello, {name}!"); // <-- No no no.
		}

		public override string ToString() {
			return $"Name: {this.Name} \n" +
				   $"Height: {this.Height} m \n" +
				   $"Date of Birth: {this.DateOfBirth:yyyy-MM-dd} \n" +
				   $"Age: {this.Age}";
		}
	}
}
