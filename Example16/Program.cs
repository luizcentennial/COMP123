using Example16.Models;

namespace Example16 {
	class Program {
		static void Main(string[] args) {
			// INTERFACES:
			// An interface is a type that defines a contract
			// with feature DEFINITIONS (usually, without implementations),
			// that other entities must implement.

			Eagle bird = new Eagle();
			bird.BirdID = "123";

			bird.Fly();

			Ostrich ostrich = new Ostrich();

			// The line below throws an error.
			//ostrich.Fly();
		}
	}
}
