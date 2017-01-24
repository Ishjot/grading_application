using Grading_App.Models;
using Grading_App.Services;
using Prism.Commands;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Grading_App.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        readonly IDataSeedService _dataSeedService;

        public MainPageViewModel(INavigationService navigationService,
                                 IDataSeedService dataSeedService)
        {
            _navigationService = navigationService;
            _dataSeedService = dataSeedService;
            DeleteCommand = new DelegateCommand(_Delete, _CanDelete);
            IncreaseGradeCommand = new DelegateCommand(_IncreaseGrade);
            AddAssignmentNavigationCommand = new DelegateCommand(_AddAssignmentNavigation);
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, 
            Dictionary<string, object> viewModelState)
        {
            if (e.Parameter == null)
            {
                _seedValues = _dataSeedService.Seed();
                Students = _seedValues.Item1;
                SelectedStudent = _seedValues.Item2;
            }
            else
            {
                Students = (e.Parameter as Tuple<ObservableCollection<Student>, Student>).Item1
                    as ObservableCollection<Student>;
                SelectedStudent = (e.Parameter as Tuple<ObservableCollection<Student>, Student>).Item2
                    as Student;
                //Students.Remove(e.Parameter as Student);
            }

            base.OnNavigatedTo(e, viewModelState);
        }

        public override void OnNavigatingFrom(NavigatingFromEventArgs e,
            Dictionary<string, object> viewModelState, bool suspending)
        {
            base.OnNavigatingFrom(e, viewModelState, suspending);
        }

        public ObservableCollection<Student> Students { get; set; }
        Student _selectedStudent;
        private Tuple<ObservableCollection<Student>, Student> _seedValues;

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set { SetProperty(ref _selectedStudent, value); }
        }

        public DataSeedService SeedValues { get; private set; }

        public ICommand DeleteCommand
        {
            get;
        }

        public ICommand IncreaseGradeCommand
        {
            get;
        }

        public ICommand AddAssignmentNavigationCommand
        {
            get;
        }

        void _Delete()
        {
            Students.RemoveAt(0);
        }

        bool _CanDelete()
        {
            return Students.Any();
        }

        void _IncreaseGrade()
        {
            var shayon = Students.FirstOrDefault(student => student.Name == "Shayon Javadizadeh");
            if (shayon != null)
            {
                for (int i = 0; i < shayon.Assignments.Count; i++)
                {
                    shayon.Assignments.ElementAt(i).addAchievedPoints(2);
                }
            }
        }

        void _AddAssignmentNavigation()
        {
            _navigationService.Navigate("AddAssignment", new Tuple<ObservableCollection<Student>, Student>(Students, SelectedStudent));
        }

    }
}
