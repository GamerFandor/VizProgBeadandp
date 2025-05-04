using System.Windows;

namespace ClassroomGamf.Views
{
    public partial class GroupSettingsWindow : Window
    {
        public GroupSettingsWindow()
        {
            InitializeComponent();

            // Ide jönne az adat betöltése, ha lenne adatbázis kapcsolat
            GroupNameTextBox.Text = "Group 1";
            MemberCountLabel.Text = "25 fő";
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Mentési logika (később adatbázisba)
            MessageBox.Show("Csoport mentve!", "Sikeres mentés", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
