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
    /// Interaction logic for AssignmentsPage.xaml
    /// </summary>
    public partial class AssignmentsPage : Page
    {
        public AssignmentsPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavToGroup();
        }

        private void FeedButton_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavToFeed();
        }

        private void MessageButton_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavToMessage();
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            var manageuser = new UserSettingsWindow("my_username", "my_username@hallgato.nje.hu");
            manageuser.ShowDialog();
        }
    }
}
