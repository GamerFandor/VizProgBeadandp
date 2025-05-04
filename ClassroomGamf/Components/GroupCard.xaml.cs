using System.Windows;
using ClassroomGamf.Views;
using System.Windows.Controls;

namespace ClassroomGamf.Components
{
    public partial class GroupCard : UserControl
    {
        public GroupCard()
        {
            InitializeComponent();
        }

        public string ImagePath
        {
            get { return (string)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }

        public static readonly DependencyProperty ImagePathProperty =
            DependencyProperty.Register("ImagePath", typeof(string), typeof(GroupCard), new PropertyMetadata(null));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(GroupCard), new PropertyMetadata(null));

        public int MemberCount
        {
            get { return (int)GetValue(MemberCountProperty); }
            set { SetValue(MemberCountProperty, value); }
        }

        public static readonly DependencyProperty MemberCountProperty =
            DependencyProperty.Register("MemberCount", typeof(int), typeof(GroupCard), new PropertyMetadata(0));

        public bool IsAdmin
        {
            get { return (bool)GetValue(IsAdminProperty); }
            set { SetValue(IsAdminProperty, value); }
        }

        public static readonly DependencyProperty IsAdminProperty =
            DependencyProperty.Register("IsAdmin", typeof(bool), typeof(GroupCard), new PropertyMetadata(false));

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            var settingsWindow = new GroupSettingsWindow(); // Lásd lejjebb
            settingsWindow.ShowDialog();
        }
    }
}
