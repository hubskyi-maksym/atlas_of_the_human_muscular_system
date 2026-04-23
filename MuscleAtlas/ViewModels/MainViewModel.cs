using pr2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows;
using System.Windows.Data;

namespace pr2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private const string DataPath = "muscles_data.json";
        public ObservableCollection<Muscle> Muscles { get; set; }

        public ICollectionView MusclesView { get; }

        private string _selectedCategory = "Всі";
        public string SelectedCategory
        {
            get => _selectedCategory;
            set
            {
                _selectedCategory = value;
                OnPropertyChanged();
                MusclesView.Refresh();
            }
        }

        public string[] Categories { get; } = { "Всі", "Голова та шия", "Тулуб", "Верхні кінцівки", "Нижні кінцівки" };

        private Muscle _selectedMuscle;
        public Muscle SelectedMuscle
        {
            get => _selectedMuscle;
            set { _selectedMuscle = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            LoadData();
            MusclesView = CollectionViewSource.GetDefaultView(Muscles);
            MusclesView.Filter = (obj) =>
            {
                if (obj is Muscle m)
                    return SelectedCategory == "Всі" || m.Category == SelectedCategory;
                return false;
            };
        }

        private void LoadData()
        {
            if (File.Exists(DataPath))
            {
                try
                {
                    string json = File.ReadAllText(DataPath);
                    Muscles = JsonSerializer.Deserialize<ObservableCollection<Muscle>>(json);
                }
                catch { InitializeDefaultData(); }
            }
            else { InitializeDefaultData(); }
        }

        public void SaveData()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(DataPath, JsonSerializer.Serialize(Muscles, options));
        }
        private void InitializeDefaultData()
        {
            try
            {
                string filePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Resources", "muscles.json");

                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var muscleList = JsonSerializer.Deserialize<List<Muscle>>(jsonString, options);

                    if (muscleList != null)
                    {
                        Muscles = new ObservableCollection<Muscle>(muscleList);
                    }
                }
                else
                {
                    MessageBox.Show($"Файл не знайдено за шляхом:\n{filePath}");
                    Muscles = new ObservableCollection<Muscle>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}