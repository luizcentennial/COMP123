using System;
using System.Windows;

namespace Example26 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		// The method below is an event handler, which is
		// triggered when the linked button is clicked.
		// Event handlers ALWAYS define two parameters:
		// - Sender: Reference to the triggering control.
		// - Event arguments: Event meta-data.
		private void OnClick(object sender, EventArgs e) {
			// Console.WriteLine has no power here!
			MessageBox.Show("Hello!");
		}
	}
}
