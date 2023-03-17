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
			
			Car car = new Car("BMW", "Z5", 2023, true);

			Truck truck = new Truck("Dodge", "RAM", 2023);
			truck.IsExtendedCab = true;

			// The line below throws an error.
			// Abstract classes cannot be instantiated!
			//Vehicle vehicle = new Vehicle("", "", 0);

			// POLYMORPHISM:
			// Polymorphism is about acknowledging the hierarchical
			// relationships that may exist between two or more types.
			// In other words, if we assume a type `T` with a sub-type `S`,
			// then Polymorphism allows us to treat an instance of type `S`
			// as an instance of type `T`.

			// Polymorphic declaration:
			Vehicle vehicle = new Car("BMW", "Z5", 2023, true);

			// Polymorphic arrays:
			Vehicle[] vehicles = { car, truck, vehicle };
		}
	}
}
