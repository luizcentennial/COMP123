using Example16.Interfaces;

namespace Example16.Models {
	public class Eagle : Bird, IFlyingBird {
		// Implement all Eagle-specific features here.

		public void Fly() {
			// Method implementation.
			System.Console.WriteLine("Eagle is flying.");
		}
	}
}
