using System;

namespace Example04.Models {
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
		// A default constructor is provided by C#
		// when an instantiatable class does not explicitly define constructors.
		// There is an invisible constructor here, we just don't see it.
	}
}
