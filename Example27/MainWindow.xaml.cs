using System;
using System.Windows;

namespace Example27 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void OnSignIn(object sender, EventArgs e) {
			// Named controls can be accessed in the code-behind like any other class field.
			// Since txtName is a TextBox, we can retrieve its current value from property 'Text'.
			string name = txtName.Text;

			if (!string.IsNullOrWhiteSpace(name)) {
				MessageBox.Show($"Login successful with username {name}!", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
			}
			else {
				MessageBox.Show("Username not provided.", "Error.", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}
