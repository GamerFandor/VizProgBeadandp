using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassroomGamf.Views
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavToRegister();
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            var managegroup = new GroupSettingsWindow();
            managegroup.ShowDialog();
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            var manageuser = new UserSettingsWindow("my_username", "my_username@hallgato.nje.hu");
            manageuser.ShowDialog();
        }

        private void GroupButton_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavToFeed();
        }
    }
}
