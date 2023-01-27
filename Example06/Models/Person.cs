using System;

namespace Example06.Models {
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
		private Person() {
			this.Name = "Untitled";
		}

		private Person(string name) {
			this.Name = name;
		}

		// A constructor can reference other constructors,
		// so as to avoid code repetition.
		private Person(string name, DateTime dob) : this(name) {
			this.DateOfBirth = dob;
		}

		// Methods
		public static Person CreatePerson(string name, DateTime dob) {
			// Since all constructors are private, this
			// method is the only choice for instantiation.
			Person person = new Person(name, dob);

			return person;
		}
	}
}
