using System;
using System.Windows;
using System.Windows.Controls;

namespace pr2.Views
{
    public partial class SettingsPage : Page
    {
        // 1. Стандартний конструктор (викликається при натисканні на меню)
        public SettingsPage()
        {
            InitializeComponent();
        }

        // 2. Конструктор з аргументом (ВИПРАВЛЯЄ ПОМИЛКУ CS1729)
        // Цей конструктор буде приймати дані з ListPage, але ми його просто ігноруємо тут
        public SettingsPage(string passedData)
        {
            InitializeComponent();
        }

        // --- Логіка перемикання тем ---
        private void SetLightTheme_Click(object sender, RoutedEventArgs e)
        {
            UpdateTheme("Resources/LightTheme.xaml");
        }

        private void SetDarkTheme_Click(object sender, RoutedEventArgs e)
        {
            UpdateTheme("Resources/DarkTheme.xaml");
        }

        private void UpdateTheme(string themePath)
        {
            // Створюємо словник для нової теми
            ResourceDictionary newTheme = new ResourceDictionary { Source = new Uri(themePath, UriKind.Relative) };

            // Очищуємо старі словники кольорів (вони зазвичай перші в списку)
            Application.Current.Resources.MergedDictionaries.Clear();

            // Додаємо нову тему і загальні стилі (але тепер використовуємо динамічні ресурси)
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("Resources/Styles.xaml", UriKind.Relative) });
        }
    }
}