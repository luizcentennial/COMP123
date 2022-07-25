using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12.Models {
	public class Person {
		public string Name { get; set; }
		public double Height { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Age {
			get {
				int age = DateTime.Now.Year - this.DateOfBirth.Year;

				if (DateTime.Now.DayOfYear < this.DateOfBirth.DayOfYear) {
					age--;
				}

				return age;
			}
		}

		public Person() {
			this.DateOfBirth = DateTime.Now;
		}

		public Person(DateTime dob) {
			this.DateOfBirth = dob;
		}

		public void Speak() {
			Console.WriteLine("Bla bla bla..."); // No no no.
		}

		public virtual void Greet(string name) {
			string greeting = this.CreateGreeting(name);

			Console.WriteLine(greeting); // No no no.
		}

		protected string CreateGreeting(string name) {
			return $"Hello, {name}";
		}
	}
}
