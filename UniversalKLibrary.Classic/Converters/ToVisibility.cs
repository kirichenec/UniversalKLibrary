using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace UniversalKLibrary.Classic.Converters
{
    #region BoolToVisibilityConverter
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = bool.Parse(value.ToString()) == true ? Visibility.Visible : Visibility.Collapsed;
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region BoolToVisibilityInvertedConverter
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BoolToVisibilityInvertedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = bool.Parse(value.ToString()) == false ? Visibility.Visible : Visibility.Collapsed;
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region StringBoolToVisibilityConverter
    [ValueConversion(typeof(string), typeof(Visibility))]
    public class StringBoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return bool.Parse(value?.ToString()) == true ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region StringBoolToVisibilityInvertedConverter
    [ValueConversion(typeof(string), typeof(Visibility))]
    public class StringBoolToVisibilityInvertedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return bool.Parse(value.ToString()) == false ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region StringToVisibilityConverter
    [ValueConversion(typeof(string), typeof(Visibility))]
    public class StringToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Visibility)Enum.Parse(typeof(Visibility), value?.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region StringToVisibilityInvertedConverter
    [ValueConversion(typeof(string), typeof(Visibility))]
    public class StringToVisibilityInvertedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Visibility)Enum.Parse(typeof(Visibility), value?.ToString()) == Visibility.Visible ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
