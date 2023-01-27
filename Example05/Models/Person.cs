using System;

namespace Example05.Models {
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
			set {
				if (value.Year < 2000) {
					this._dateOfBirth = value;
				}
				else {
					// Ignore.
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
		public Person() { // <-- Parameterless constructor
			// This is NOT a default constructor.
			// Initialization logic.
			// For example, setting default values:
			this.Name = "Untitled";
		}

		public Person(string name) { // <-- Parameterized constructor
			// Initialization logic.
			this.Name = name;
		}

		public Person(string name, DateTime dob) : this(name) { // <-- Parameterized constructor
			// Initialization logic.
			this.DateOfBirth = dob;
		}
	}
}
