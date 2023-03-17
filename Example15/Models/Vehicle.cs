namespace Example15.Models {
	public abstract class Vehicle {
		public string Make { get; set; }
		public string Model { get; set; }
		public uint Year { get; set; }

		public Vehicle(string make, string model, uint year) {
			this.Make = make;
			this.Model = model;
			this.Year = year;

			this.SomePrivateMethod();
		}

		public override string ToString() {
			return $"Make: {this.Make} \n" +
				   $"Model: {this.Model} \n" +
				   $"Year: {this.Year} ";
		}

		protected void SomePrivateMethod() { 
			// Some logic.
		}
	}
}
