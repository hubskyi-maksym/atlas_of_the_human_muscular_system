using System.Windows;
using System.Windows.Controls;
using pr2.ViewModels;

namespace pr2.Views
{
    public partial class ListPage : Page
    {
        private MainViewModel _viewModel;

        public ListPage()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            this.DataContext = _viewModel;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.SaveData();
            MessageBox.Show("Дані успішно збережено!", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}