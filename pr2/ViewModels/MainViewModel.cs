using System.Collections.ObjectModel;
using pr2.Models;

namespace pr2.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Muscle> Muscles { get; set; }

        public MainViewModel()
        {
            Muscles = new ObservableCollection<Muscle>
            {
                new Muscle { Name = "Массетер", Category = "Голова", LatinName = "Musculus masseter", Description = "Жувальний м'яз, один із найсильніших у людини." },
                new Muscle { Name = "Біцепс", Category = "Руки", LatinName = "Musculus biceps brachii", Description = "Двоголовий м'яз плеча, згинає руку в лікті." },
                new Muscle { Name = "Прямий м'яз живота", Category = "Тулуб", LatinName = "Musculus rectus abdominis", Description = "Той самий м'яз, що утворює 'прес'." },
                new Muscle { Name = "Великий сідничний", Category = "Ноги", LatinName = "Musculus gluteus maximus", Description = "Найбільший м'яз тіла." }
            };
        }
    }
}