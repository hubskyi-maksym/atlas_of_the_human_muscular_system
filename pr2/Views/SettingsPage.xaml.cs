using System.Windows.Controls;

namespace pr2.Views
{
    public partial class SettingsPage : Page
    {

        public SettingsPage()
        {
            InitializeComponent();
        }

        public SettingsPage(string passedData)
        {
            InitializeComponent();

            TxtParameter.Text = $"Отримані дані: {passedData}";
            TxtParameter.Foreground = System.Windows.Media.Brushes.Green;
        }
    }
}