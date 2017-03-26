namespace WPF_Lab1.Models.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    public sealed class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var booleanValue = (bool)value;
            if ((string)parameter == "invert")
            {
                booleanValue = !booleanValue;
            }

            return booleanValue ? Visibility.Visible : Visibility.Collapsed;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var visibilityValue = (Visibility)value;
            if ((string)parameter == "invert")
            {
                visibilityValue = visibilityValue == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
            }

            return visibilityValue == Visibility.Visible;
        }
    }
}
