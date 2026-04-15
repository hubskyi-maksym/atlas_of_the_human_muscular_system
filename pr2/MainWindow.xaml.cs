using System.Windows;

namespace pr2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            string name = TxtMuscleName.Text;
            string group = TxtMuscleGroup.Text;

            StatusText.Text = $"Виконується пошук: {name} ({group})";

            MessageBox.Show($"Шукаємо м'яз:\nНазва: {name}\nГрупа: {group}",
                            "Результат пошуку",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            TxtMuscleName.Clear();
            TxtMuscleGroup.Clear();

            StatusText.Text = "Поля пошуку очищено";
        }

        private void BtnDetails_Click(object sender, RoutedEventArgs e)
        {
            StatusText.Text = "Завантаження детальної інформації...";
            MessageBox.Show("Тут відкриється нове вікно з моделлю та деталями.",
                            "Деталі анатомії");
        }
    }
}