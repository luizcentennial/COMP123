namespace Example15.Models {
	public class Car : Vehicle {
		public bool IsConvertible { get; set; }

		public Car() {
			this.SomePrivateMethod();
		}
	}
}
