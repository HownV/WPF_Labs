using System;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPF_Lab1.Models.Navigation
{
    public static class NavigationProvider
    {
        private static Frame _frame;

        private static object parameter;

        private static ParameterMode parameterMode;

        public static void SetFrame(Frame frame)
        {
            if (_frame == null)
            {
                _frame = frame;
            }
            else
            {
                throw new InvalidOperationException("The Frame is already exist.");
            }
        }

        public static bool NavigateTo(Uri source, object parameter, ParameterMode parameterMode)
        {
            NavigationProvider.Parameter = parameter;
            NavigationProvider.ParameterMode = parameterMode;
            return _frame.Navigate(source);
        }

        public static object Parameter
        {
            get
            {
                var result = parameter;
                parameter = null;
                return result;
            }

            private set { parameter = value; }
        }

        public static ParameterMode ParameterMode
        {
            get 
            {
                var result = parameterMode;
                parameterMode = ParameterMode.Default;
                return result;
            }

            private set { parameterMode = value; }
        }
    }
}
