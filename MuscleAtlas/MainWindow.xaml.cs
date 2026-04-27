using System.Windows;
using MuscleAtlas.Views; 

namespace MuscleAtlas
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