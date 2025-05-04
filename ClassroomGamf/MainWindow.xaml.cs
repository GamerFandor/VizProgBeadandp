using System.Windows;
using ClassroomGamf.Views;

namespace ClassroomGamf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new RegisterPage()); // Kezdés regisztrációs oldallal
        }

        public void NavToLogin()
        {
            MainFrame.Navigate(new Login());
        }

        public void NavToRegister()
        {
            MainFrame.Navigate(new RegisterPage());
        }

        public void NavToGroup()
        {
            MainFrame.Navigate(new HomePage());
        }

        public void NavToFeed()
        {
            MainFrame.Navigate(new Group());
        }

        public void NavToAssignments()
        {
            MainFrame.Navigate(new AssignmentsPage());
        }

        public void NavToMessage()
        {
            MainFrame.Navigate(new MessagePage());
        }
    }
}
