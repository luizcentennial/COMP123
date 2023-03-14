namespace Example15.Models {
	public abstract class Vehicle {
		// Vehicle is an abstract class. That means it 
		// cannot be instantiated.
		// This is a restriction that may or may not exist,
		// depending on technical specifications. However,
		// it is not uncommon to find super-types that are
		// marked abstract.

		// Through Inheritance, all class members that are
		// not private will be cascaded down to sub-types.
		// This allows for maximum reusability and minimized
		// code duplication.

		public string Make { get; set; }
		public string Model { get; set; }
		public uint Year { get; set; }

		public Vehicle() {
			this.SomePrivateMethod();
		}

		public override string ToString() {
			return $"Make: {this.Make} \n" +
				   $"Model: {this.Model} \n" +
				   $"Year: {this.Year} ";
		}

		protected void SomePrivateMethod() { 
			// Method implementation.
		}
	}
}
