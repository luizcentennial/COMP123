using System.Windows;

namespace Example28 {
	/*
		Implement a desktop application for a bank.

		The application should allow users to create accounts, as well as transactions (credit or debit) against those accounts.

		PART 1: DOMAIN:
		- Implement classes that allow for the proper maintenance of the relevant entities for the context of this application. 

		PART 2: UI:
		- Implement a user interface that allows users to create accounts.

		PART 3: IMPLEMENTATION:
		- Implement the required functionality. Use XML serialization for data persistence.
	*/
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}
	}
}
