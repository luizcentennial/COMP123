using Example17.Factories;
using Example17.Models;

namespace Example17 {
	class Program {
		static void Main(string[] args) {
			// THE FACTORY DESIGN PATTERN:
			//Factory Method is a creational design pattern 
			//that provides an interface for creating instances
			//of a class.

			//Use the Factory Pattern when you need strict
			//control on how instances of a class are created.

			VehicleFactory factory = new VehicleFactory();

			Car car = (Car)factory.Create(VehicleType.Car);
			Truck truck = (Truck)factory.Create(VehicleType.Truck);
		}
	}
}
