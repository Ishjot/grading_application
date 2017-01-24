using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_App.Models
{
    public class Student : BindableBase
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        ObservableCollection<Assignment> _assignments;
        public ObservableCollection<Assignment> Assignments
        {
            get { return _assignments; }
            set { SetProperty(ref _assignments, value); }
        }

        public void AddAssignment(string name, int achievedPoints, int totalPoints)
        {
            _assignments.Add(new Assignment(name, achievedPoints, totalPoints));
        }
    }
}
