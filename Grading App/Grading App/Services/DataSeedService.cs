using Grading_App.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Grading_App.Services
{
    public class DataSeedService : IDataSeedService {
        static Random Rand = new Random();
        public Student SelectedStudent { get; private set; }
        public ObservableCollection<Student> Students { get; private set; }

        public Tuple<ObservableCollection<Student>, Student> Seed()
        {
            Students = new ObservableCollection<Student>
                {
                new Student { Name = "Allan Smith", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Denise Orozco", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Drew Seward", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Ishjot Walia", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Jim Gilmartin", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Juan J. Ramirez", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Kelli Kearns", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Lucas Rowley", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Nolan Blew", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Riley Herman", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Sam Close", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Shayon Javadizadeh", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Terrence Cole", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Tim Weyel", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Zac Stringham", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Crystal Ophaso", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Matthre Glodack", Assignments = new ObservableCollection<Assignment>() },
                new Student { Name = "Tracy Mcalphin", Assignments = new ObservableCollection<Assignment>() }
                };

            SelectedStudent = Students.FirstOrDefault();

            string name;
            for (int i = 0; i < Students.Count; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    name = "Assignment #" + (j + 1);
                    Students.ElementAt(i).Assignments.Add(new Assignment(name, Rand.Next(10, 100)));
                }
            }

            return Tuple.Create(Students, SelectedStudent);
        }
    }
}
