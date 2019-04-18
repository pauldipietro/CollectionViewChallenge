using System;
using System.Globalization;
using Xamarin.Forms;

namespace CollectionViewChallenge.Converters
{
    internal class BoolToInverse : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
