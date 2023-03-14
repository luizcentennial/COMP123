using Example15.Models;

namespace Example15 {
	class Program {
		static void Main(string[] args) {
			// INHERITANCE:
			// Inheritance is the ability to define hierarchical
			// relationships between two or more types.
			// The class that stands above in that relationship
			// is the "super-class", while the one that stands
			// below is the "sub-class". 
			// In other words, super-classes are "parent" types
			// that sub-classes ("child" types) extend with specialized features.

			Car car = new Car();
			car.Make = "BMW";
			car.Model = "Z5";
			car.Year = 2023;
			car.IsConvertible = true;

			Truck truck = new Truck();
			truck.Make = "Ford";
			truck.Model = "F150";
			truck.Year = 2023;
			truck.IsExtendedCab = true;

			// The line below throws an error.
			//Vehicle vehicle = new Vehicle();

			// Declaring objects polymorphically:
			Vehicle another = new Truck();
			another.Make = "Dodge";
			another.Model = "RAM";
			another.Year = 2023;

			((Truck)another).IsExtendedCab = true;
		}
	}
}
