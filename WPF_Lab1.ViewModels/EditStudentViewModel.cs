using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using WPF_Lab1.Models;
using WPF_Lab1.Models.Navigation;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using WPF_Lab1.Models.DataAccess;

namespace WPF_Lab1.ViewModels
{
    public class EditStudentViewModel : ViewModelBase
    {
        private DatabaseContext _dbContext = new DatabaseContext();

        private Student _student;

        private Group _studentGroup;

        private bool _canEdit = false;

        private bool _hasErrors = false;

        public EditStudentViewModel()
        {
            var parameter = NavigationProvider.Parameter;
            if (parameter is Student student)
            {
                CurrentStudent = student;
            }
            else
            {
                CurrentStudent = new Student() { StudentId = Guid.NewGuid() };
                _studentGroup = (Group) parameter; 
            }

            var parameterMode = NavigationProvider.ParameterMode;
            if (parameterMode == ParameterMode.Create || parameterMode == ParameterMode.Update)
            {
                CanEdit = true;
            }

            SaveChangesCommand = new RelayCommand(SaveChangesExecute, SaveChangesCanExecute);
        }
        
        public ICommand SaveChangesCommand { get; set; } 
        
        public bool CanEdit
        {
            get { return _canEdit; }
            set
            {
                _canEdit = value;
                base.RaisePropertyChanged();
            }
        }

        public bool HasErrors
        {
            get { return _hasErrors; }
            set
            {
                _hasErrors = value;
                base.RaisePropertyChanged();
                SaveChangesCommand.CanExecute(null);
            }
        }
        
        public Student CurrentStudent
        {
            get { return _student; }
            set
            {
                _student = value;
                base.RaisePropertyChanged();
            }
        }

        private void SaveChangesExecute()
        {
            var currentGroup = _dbContext.Groups.Include(x => x.Students).First(x => x.GroupId == _studentGroup.GroupId);
            currentGroup.Students.Add(_student);
            _dbContext.SaveChanges();

            NavigationProvider.NavigateTo(NavigationSource.GroupsPage, null, ParameterMode.Default);
        }
        private bool SaveChangesCanExecute()
        {
            var result = true;
            if (string.IsNullOrEmpty(CurrentStudent.PersonalPhoneNumber) 
                || string.IsNullOrEmpty(CurrentStudent.ParentPhoneNumber) 
                || HasErrors)
            //string.IsNullOrEmpty(CurrentStudent.Name) || string.IsNullOrWhiteSpace(CurrentStudent.Name)
            //|| CurrentStudent.DateOfBirth < new DateTime(1990, 1, 1) || CurrentStudent.DateOfBirth > DateTime.Now
            //|| CurrentStudent.Domicile.Length < 10
            //|| HasErrors
            //|| CurrentStudent.Balance < -50000
            //|| CurrentStudent.RatingPoints < -100
            //|| string.IsNullOrEmpty(CurrentStudent.Characterization) 
            //|| string.IsNullOrWhiteSpace(CurrentStudent.Characterization))
            {
                result = false;
            }

            return result;
        }
    }
}
