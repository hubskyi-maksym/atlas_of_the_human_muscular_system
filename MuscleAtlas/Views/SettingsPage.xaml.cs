using System.Windows;
using System.Windows.Controls;

namespace pr2.Views
{
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SetLightTheme_Click(object sender, RoutedEventArgs e)
        {
            App.SetTheme("Light");
        }

        private void SetDarkTheme_Click(object sender, RoutedEventArgs e)
        {
            App.SetTheme("Dark");
        }
    }
}