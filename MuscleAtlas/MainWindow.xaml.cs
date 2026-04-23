using System.Windows;
using pr2.Views; 

namespace pr2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HomePage());
        }

        private void NavHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void NavList_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListPage());
        }

        private void NavSettings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SettingsPage());
        }
    }
}