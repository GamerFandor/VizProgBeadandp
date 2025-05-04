using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ClassroomGamf.Views
{
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;
            string confirmPassword = ConfirmPasswordBox.Password;

            if (password != confirmPassword)
            {
                MessageBox.Show("A jelszavak nem egyeznek.", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // TODO: Validation and saving logic
            MessageBox.Show("Regisztráció sikeres!", "Siker", MessageBoxButton.OK, MessageBoxImage.Information);

            // Navigate to login page
            ((MainWindow)Application.Current.MainWindow).NavToGroup();
        }

        private void GoToLogin_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavToLogin();
        }
    }
}
