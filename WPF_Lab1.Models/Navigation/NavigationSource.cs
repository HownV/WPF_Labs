using System;

namespace WPF_Lab1.Models.Navigation
{
    public static class NavigationSource
    {
        public static readonly Uri GroupsPage = new Uri("Views/GroupsPage.xaml", UriKind.Relative);
        
        public static readonly Uri EditStudentPage = new Uri("Views/EditStudentPage.xaml", UriKind.Relative);

        public static readonly Uri SearchPage = new Uri("Views/SearchPage.xaml", UriKind.Relative);
    }
}
