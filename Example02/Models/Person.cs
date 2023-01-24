using System;

namespace Example02.Models {
	public class Person {
		// Properties
		public string Name { get; set; } // Auto-implemented property
		public double Height { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Age { // Auto-calculated property
			get {
				int age = DateTime.Now.Year - this.DateOfBirth.Year;

				if (DateTime.Now.DayOfYear < this.DateOfBirth.DayOfYear) {
					age--;
				}

				return age;
			}
		}
	}
}
