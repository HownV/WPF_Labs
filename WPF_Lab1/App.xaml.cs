using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Lab1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //NavigationProvider.SetFrame(new Frame() {Source = NavigationSource.GroupsPage});
        }
    }
}
