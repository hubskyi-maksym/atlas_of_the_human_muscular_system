using System.Windows.Controls;
using pr2.ViewModels;

namespace pr2.Views
{
    public partial class ListPage : Page
    {
        public ListPage()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }
    }
}