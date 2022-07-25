using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12.Models.Interfaces {
	public interface IStudyingPerson {
		// Interfaces are "contracts".
		// Interfaces define functionality that implementing classes MUST implement.
		// Usually, method implementations are not included in interfaces - just definitions.
		// However, in newer C# versions, method implementation in interfaces is allowed.

		// The differences between classes and interfaces are:
		// - Classes: Implement functionality (may just define functionality occasionally - i.e. abstract methods).
		// - Interfaces: Define functionality (may implement functionality occasionally, in newer C# versions).
		// - Sub-classes can extend one, and only one, super-class.
		//   However, they can implement multiple interfaces.
		// - Interfaces cannot be instantiated.

		// The advantage of using interfaces is that it allows for better abstraction models.
		// It allows for more flexible and customizeable abstraction models.
		// Functionality as "plug-and-play" features.

		public void Study(); // <-- This is a method DECLARATION. It does not include a body.
	}
}
