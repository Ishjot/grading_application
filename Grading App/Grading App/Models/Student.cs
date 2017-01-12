using Prism.Mvvm;
using System;
using System.Collections.Generic;
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
        int _grade;
        public int Grade
        {
            get { return _grade; }
            set { SetProperty(ref _grade, value); }
        }
    }
}
