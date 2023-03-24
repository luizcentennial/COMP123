using Example16.Models.Interfaces;

namespace Example16.Models {
	public class Eagle : Bird, IFlyingBird {
		public void Fly() {
			System.Console.WriteLine("Eagle is flying."); // <-- No no no.
		}
	}
}
