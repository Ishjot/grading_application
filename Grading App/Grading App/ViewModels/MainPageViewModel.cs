using Grading_App.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Grading_App.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public MainPageViewModel()
        {
            DeleteCommand = new DelegateCommand(_Delete, _CanDelete);
            IncreaseGradeCommand = new DelegateCommand(_IncreaseGrade);
            var Rand = new Random();
            Students = new ObservableCollection<Student>
            {
            new Student { Name = "Allan Smith", Grade = Rand.Next(0,100) },
            new Student { Name = "Denise Orozco", Grade = Rand.Next(0,100) },
            new Student { Name = "Drew Seward", Grade = Rand.Next(0,100) },
            new Student { Name = "Ishjot Walia", Grade = Rand.Next(0,100) },
            new Student { Name = "Jim Gilmartin", Grade = Rand.Next(0,100) },
            new Student { Name = "Juan J. Ramirez", Grade = Rand.Next(0,100) },
            new Student { Name = "Kelli Kearns", Grade = Rand.Next(0,100) },
            new Student { Name = "Lucas Rowley", Grade = Rand.Next(0,100) },
            new Student { Name = "Nolan Blew", Grade = Rand.Next(0,100) },
            new Student { Name = "Riley Herman", Grade = Rand.Next(0,100) },
            new Student { Name = "Sam Close", Grade = Rand.Next(0,100) },
            new Student { Name = "Shayon Javadizadeh", Grade = Rand.Next(0,100) },
            new Student { Name = "Terrence Cole", Grade = Rand.Next(0,100) },
            new Student { Name = "Tim Weyel", Grade = Rand.Next(0,100) },
            new Student { Name = "Zac Stringham", Grade = Rand.Next(0,100) },
            new Student { Name = "Crystal Ophaso", Grade = Rand.Next(0,100) },
            new Student { Name = "Matthre Glodack", Grade = Rand.Next(0,100) },
            new Student { Name = "Tracy Mcalphin", Grade = Rand.Next(0,100) }
            };
        }

        public ObservableCollection<Student> Students { get; }
        int _grade;
        public int Grade
        {
            get { return _grade; }
            set { SetProperty(ref _grade, value); }
        }

        public ICommand DeleteCommand
        {
            get;
        }

        public ICommand IncreaseGradeCommand
        {
            get;
        }

        void _IncreaseGrade()
        {
            var shayon = Students.FirstOrDefault(student => student.Name == "Shayon Javadizadeh");
            if (shayon != null)
            {
                shayon.Grade += 10;
            }
        }

        void _Delete()
        {
            Students.RemoveAt(0);
        }

        bool _CanDelete()
        {
            return Students.Any();
        }

    }
}
