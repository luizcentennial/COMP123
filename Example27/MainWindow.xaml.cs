using System.Windows;

namespace Example27
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSignIn(object sender, EventArgs e)
        {
            // Named controls can be accessed in the code-behind like any other class field.
            // Since txtName is a TextBox, we can retrieve its current value from property 'Text'.

            string username = this.txtUsername.Text;
            string password = this.pwdPassword.Password; // <-- NO! This is terribly insecure. 

            if (username == "john" && password == "123")
            {
                MessageBox.Show("Login successful!", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}