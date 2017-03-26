using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using WPF_Lab1.Models;
using WPF_Lab1.Models.DataAccess;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;

namespace WPF_Lab1.ViewModels
{
    public class SearchViewModel : ViewModelBase
    {
        private DatabaseContext _dbContext = new DatabaseContext();

        private ICollection<Student> _allStudents;
        
        private ICollection<Student> _searchResult;

        private string _pattern;

        public SearchViewModel()
        {
            SearchCommand = new RelayCommand(SearchExecute);

            _allStudents = (from groupp in _dbContext.Groups.Include(x => x.Students)
                        from student in groupp.Students
                        select student).ToList();
            Students = _allStudents;
        }

        public ICommand SearchCommand { get; set; }

        public ICollection<Student> Students
        {
            get
            {
                return _searchResult;
            }

            set
            {
                _searchResult = value;
                base.RaisePropertyChanged();
            }
        }

        public string Pattern
        {
            get
            {
                return _pattern;
            }

            set
            {
                _pattern = value;
                base.RaisePropertyChanged();
            }
        }

        private void SearchExecute()
        {
            if (!string.IsNullOrEmpty(Pattern))
            {
                Students = (from student in _allStudents
                            where student.Name.Contains(Pattern)
                            select student).ToList();
            }
            else
            {
                Students = _allStudents;
            }
        }
    }
}
