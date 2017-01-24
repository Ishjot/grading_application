using Grading_App.Models;
using Prism.Commands;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Grading_App.ViewModels
{
    class AddAssignmentPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        Student _selectedStudent;

        public AddAssignmentPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            MainPageNavigationCommand = new DelegateCommand(_MainPageNavigation);
            AddAssignmentCommand = new DelegateCommand(_AddAssignment);
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);

            if (e.Parameter != null)
            {
                Students = (e.Parameter as Tuple<ObservableCollection<Student>, Student>).Item1
                    as ObservableCollection<Student>;
                SelectedStudent = (e.Parameter as Tuple<ObservableCollection<Student>, Student>).Item2
                    as Student;
            }
        }

        public override void OnNavigatingFrom(NavigatingFromEventArgs e, Dictionary<string, object> viewModelState, bool suspending)
        {
            base.OnNavigatingFrom(e, viewModelState, suspending);
        }

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set { SetProperty(ref _selectedStudent, value); }
        }

        public ObservableCollection<Student> Students { get; set; }

        public ICommand MainPageNavigationCommand
        {
            get;
        }

        void _MainPageNavigation()
        {
            _navigationService.Navigate("Main", 
                new Tuple<ObservableCollection<Student>, Student>(Students, SelectedStudent));
        }

        public ICommand AddAssignmentCommand
        {
            get;
        }

        void _AddAssignment()
        {
            SelectedStudent.AddAssignment("New", 0, 100);
        }

    }
}
