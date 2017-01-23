using Grading_App.Models;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using System.Collections.Generic;

namespace Grading_App.ViewModels
{
    class AddAssignmentPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        Student _selectedStudent;

        public AddAssignmentPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);

            if (e.Parameter != null)
            {
                SelectedStudent = e.Parameter as Student;
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

    }
}
