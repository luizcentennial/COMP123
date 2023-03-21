namespace Example17.Models {
	public class Car : Vehicle {
		public bool IsConvertible { get; set; }

		public Car(string make, string model, uint year, bool isConvertible) : base(make, model, year) {
			this.IsConvertible = isConvertible;
		}

		private void AnotherPrivateMethod() {
			this.SomePrivateMethod();
		}
	}
}
