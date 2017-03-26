using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Data.Entity;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using WPF_Lab1.Models;
using WPF_Lab1.Models.DataAccess;
using WPF_Lab1.Models.Navigation;
using System;
using System.IO;

namespace WPF_Lab1.ViewModels
{
    public class GroupsViewModel : ViewModelBase
    {
        private DatabaseContext _dbContext = new DatabaseContext();

        private Group _selectedGroup;

        private Student _selectedStudent;

        public GroupsViewModel()
        {
            Groups = new ObservableCollection<Group>(_dbContext.Groups.Include(x => x.Students)
                .Include(x => x.ClassroomTeacher));

            NavigateToAddNewStudentPageCommand = new RelayCommand(
                () => NavigationProvider.NavigateTo(NavigationSource.EditStudentPage, _selectedGroup, ParameterMode.Create),
                () => _selectedGroup != null);

            NavigateToEditStudentPageCommand = new RelayCommand(
                () => NavigationProvider.NavigateTo(NavigationSource.EditStudentPage, _selectedStudent, ParameterMode.Update), 
                () => _selectedStudent != null);

            NavigateToStudentDetailsPageCommand = new RelayCommand(
                () => NavigationProvider.NavigateTo(NavigationSource.EditStudentPage, _selectedStudent, ParameterMode.Read), 
                () => _selectedStudent != null);
        }
        
        public ObservableCollection<Group> Groups { get; set; }

        public Group SelectedGroup
        {
            get
            {
                return _selectedGroup;
            }
            set
            {
                _selectedGroup = value;
                base.RaisePropertyChanged();
            }
        }

        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }
            set
            {
                _selectedStudent = value;
                base.RaisePropertyChanged();
            }
        }

        public ICommand NavigateToStudentDetailsPageCommand { get; set; }

        public ICommand NavigateToEditStudentPageCommand { get; set; }

        public ICommand NavigateToAddNewStudentPageCommand { get; set; }

        //private void NavigateToStudentDetailsPageExecute()
        //{
        //    NavigationProvider.NavigateTo(NavigationSource.StudentDetailsPage, _selectedStudent);
        //}
        //private bool NavigateToStudentDetailsPageCanExecute()
        //{
        //    return _selectedStudent != null;
        //}

        //private void NavigateToAddNewStudentPageExecute()
        //{
        //    NavigationProvider.NavigateTo(NavigationSource.EditStudentPage, _selectedGroup);
        //}
        //private bool NavigateToAddNewStudentPageCanExecute()
        //{
        //    return _selectedGroup != null;
        //}

        //private void NavigateToEditStudentPageExecute()
        //{
        //    NavigationProvider.NavigateTo(NavigationSource.EditStudentPage, _selectedStudent);
        //}
        //private bool NavigateToEditStudentPageCanExecute()
        //{
        //    return _selectedStudent != null;
        //}
    }
}
