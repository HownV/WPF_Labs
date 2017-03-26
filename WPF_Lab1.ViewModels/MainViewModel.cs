using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using WPF_Lab1.Models.Navigation;

namespace WPF_Lab1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            NavigateToGroupsPageCommand = new RelayCommand(NavigateToGroupsPageExecute);
            NavigateToSearchPageCommand = new RelayCommand(NavigateToSearchPageExecute);
        }

        public ICommand NavigateToGroupsPageCommand { get; set; }

        public ICommand NavigateToSearchPageCommand { get; set; }

        private void NavigateToGroupsPageExecute()
        {
            NavigationProvider.NavigateTo(NavigationSource.GroupsPage, null, ParameterMode.Default);
        }

        private void NavigateToSearchPageExecute()
        {
            NavigationProvider.NavigateTo(NavigationSource.SearchPage, null, ParameterMode.Default);
        }

    }
}
