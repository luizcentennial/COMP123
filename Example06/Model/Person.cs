using System;

namespace Example06.Model {
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
			// This is NOT a default constructor.
		}

		private Person(string name) {
			// Initialization logic.
			this.Name = name;
		}

		private Person(string name, DateTime dob) : this(name) { 
			// Initialization logic.
			this.DateOfBirth = dob;
		}

		// Methods
		public static Person CreatePerson(string name, DateTime dob) {
			// Complex intialization logic here.
			// Since all constructors in this class are private, this method
			// is the only choice for class instantiation.
			Person person = new Person(name, dob);

			return person;
		}
	}
}
