using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_App.Models
{
    public class Assignment : BindableBase
    {
        private static Random Rand = new Random();
        public Assignment(string name, int totalPoints)
        {
            Name = name;
            TotalPoints = totalPoints;
            AchievedPoints = Rand.Next(0, totalPoints);
        }

        public void addAchievedPoints(int change)
        {
            if (AchievedPoints + change > TotalPoints)
                return;
            AchievedPoints += change;
        }

        string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        int _totalPoints;
        public int TotalPoints
        {
            get { return _totalPoints; }
            set
            {
                //if (SetProperty(ref _totalPoints, value))
                //{
                //    OnPropertyChanged(nameof(Percentage));
                //}
                SetProperty(ref _totalPoints, value);
            }
        }

        int _achievedPoints;
        public int AchievedPoints
        {
            get { return _achievedPoints; }
            set
            {
                //if (SetProperty(ref _achievedPoints, value))
                //{
                //    OnPropertyChanged(nameof(Percentage));
                //}
                SetProperty(ref _achievedPoints, value);
            }
        }

    }
}
