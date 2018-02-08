using System;
using System.Globalization;
using System.Windows.Data;

namespace UniversalKLibrary.Standard.Converters
{
    #region InvertBoolConverter
    [ValueConversion(typeof(bool), typeof(bool))]
    public class InvertBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
    #endregion

    #region InvertFromStringConverter
    [ValueConversion(typeof(string), typeof(bool))]
    public class InvertFromStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !bool.Parse(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
