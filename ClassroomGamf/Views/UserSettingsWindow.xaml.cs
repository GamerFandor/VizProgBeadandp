using System.Windows;

namespace ClassroomGamf.Views
{
    public partial class UserSettingsWindow : Window
    {
        public UserSettingsWindow(string currentUsername, string currentEmail)
        {
            InitializeComponent();
            UsernameTextBox.Text = currentUsername;
            EmailTextBox.Text = currentEmail;
        }

        public string NewUsername => UsernameTextBox.Text;
        public string NewEmail => EmailTextBox.Text;

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // itt lehet majd validálni, adatbázisba menteni stb.
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
