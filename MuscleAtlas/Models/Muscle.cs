using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MuscleAtlas.Models
{
    public class Muscle : INotifyPropertyChanged
    {
        private string _name;
        private string _category;
        private string _description;
        private string _latinName;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); } 
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged(); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }

        public string LatinName
        {
            get { return _latinName; }
            set { _latinName = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}