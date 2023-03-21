using Example17.Factories.Interfaces;
using Example17.Models;

namespace Example17.Factories {
	public class VehicleFactory : IFactory<Vehicle, VehicleType> {
		public Vehicle Create(VehicleType type) {
			switch (type) {
				case VehicleType.Car:
					Car car = new Car(null, null, 0, false);

					return car;
				case VehicleType.Truck:
					Truck truck = new Truck(null, null, 0);

					return truck;
				default:
					throw new System.Exception($"Unknown type '{type}'.");
			}
		}
	}
}
