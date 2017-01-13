﻿using Grading_App.Models;
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
        private static Random Rand = new Random();
        public MainPageViewModel()
        {
            DeleteCommand = new DelegateCommand(_Delete, _CanDelete);
            IncreaseGradeCommand = new DelegateCommand(_IncreaseGrade);
            Students = new ObservableCollection<Student>
            {
            new Student { Name = "Allan Smith", Assignments = new List<Assignment>() },
            new Student { Name = "Denise Orozco", Assignments = new List<Assignment>() },
            new Student { Name = "Drew Seward", Assignments = new List<Assignment>() },
            new Student { Name = "Ishjot Walia", Assignments = new List<Assignment>() },
            new Student { Name = "Jim Gilmartin", Assignments = new List<Assignment>() },
            new Student { Name = "Juan J. Ramirez", Assignments = new List<Assignment>() },
            new Student { Name = "Kelli Kearns", Assignments = new List<Assignment>() },
            new Student { Name = "Lucas Rowley", Assignments = new List<Assignment>() },
            new Student { Name = "Nolan Blew", Assignments = new List<Assignment>() },
            new Student { Name = "Riley Herman", Assignments = new List<Assignment>() },
            new Student { Name = "Sam Close", Assignments = new List<Assignment>() },
            new Student { Name = "Shayon Javadizadeh", Assignments = new List<Assignment>() },
            new Student { Name = "Terrence Cole", Assignments = new List<Assignment>() },
            new Student { Name = "Tim Weyel", Assignments = new List<Assignment>() },
            new Student { Name = "Zac Stringham", Assignments = new List<Assignment>() },
            new Student { Name = "Crystal Ophaso", Assignments = new List<Assignment>() },
            new Student { Name = "Matthre Glodack", Assignments = new List<Assignment>() },
            new Student { Name = "Tracy Mcalphin", Assignments = new List<Assignment>() }
            };

            string name;
            for(int i = 0; i < Students.Count; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    name = "Assignment #" + (j+1);
                    Students.ElementAt(i).Assignments.Add(new Assignment(name, Rand.Next(10, 100)));
                }
            }
        }

        public ObservableCollection<Student> Students { get; }
        Student _selectedStudent;
        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set { SetProperty(ref _selectedStudent, value); }
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
                for(int i = 0; i < shayon.Assignments.Count; i++)
                {
                    shayon.Assignments.ElementAt(i).addAchievedPoints(2);
                }
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
