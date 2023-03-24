using Example16.Models;
using System;

namespace Example16 {
	class Program {
		static void Main(string[] args) {
			// INTERFACES:

			Eagle eagle = new Eagle();
			eagle.BirdID = "123";

			eagle.Fly();

			Ostrich ostrich = new Ostrich();
			ostrich.BirdID = "321";

			// The line below throws an error.
			//ostrich.Fly();
		}
	}
}
