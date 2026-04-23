using System.IO;
using System.Windows;
using System;

namespace pr2
{
    public partial class App : Application
    {
        private const string ThemeFilePath = "theme.txt";

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            string theme = "Light"; 
            if (File.Exists(ThemeFilePath))
            {
                theme = File.ReadAllText(ThemeFilePath);
            }

            SetTheme(theme);
        }

        public static void SetTheme(string themeName)
        {
            var app = (App)Current;
            var dictionaries = app.Resources.MergedDictionaries;

            dictionaries.Clear();

            string themePath = themeName == "Dark" ? "Resources/DarkTheme.xaml" : "Resources/LightTheme.xaml";
            dictionaries.Add(new ResourceDictionary { Source = new Uri(themePath, UriKind.Relative) });

            dictionaries.Add(new ResourceDictionary { Source = new Uri("Resources/Styles.xaml", UriKind.Relative) });

            File.WriteAllText(ThemeFilePath, themeName);
        }
    }
}