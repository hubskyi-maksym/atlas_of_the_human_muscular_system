using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace pr2.Views
{
    public partial class ListPage : Page
    {
        public ListPage()
        {
            InitializeComponent();
        }

        private void BtnPassData_Click(object sender, RoutedEventArgs e)
        {
            string myData = "Біцепс (Двоголовий м'яз плеча)";

            NavigationService.Navigate(new SettingsPage(myData));
        }
    }
}