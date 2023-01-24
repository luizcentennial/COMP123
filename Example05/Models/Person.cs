using System;

namespace Example05.Models {
	public class Person {
		// Fields
		private DateTime _dateOfBirth; // <-- DateOfBirth's value is stored here.

		// Properties
		public string Name { get; set; } // Auto-implemented property
		public double Height { get; set; }
		public DateTime DateOfBirth { // Full property
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
		public int Age { // Auto-calculated property
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
