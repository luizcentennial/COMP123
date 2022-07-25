using Example12.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12.Models {
	public class Student : Person, IStudyingPerson, IWorkingPerson {
		public StudentType Type { get; set; }

		public void Study() {
			Console.WriteLine("Studying... "); // <-- No no no.
		}

		public void Work() {
			Console.WriteLine("Working... "); // <-- No no no.
		}
	}

	public enum StudentType {
		Domestic,
		International
	}
}
