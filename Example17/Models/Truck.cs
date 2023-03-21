namespace Example17.Models {
	public class Truck : Vehicle {
		public bool IsExtendedCab { get; set; }

		public Truck(string make, string model, uint year) : base(make, model, year) {

		}
	}
}
