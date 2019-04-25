using Humanizer;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace CollectionViewChallenge.Converters
{
    public class StringDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            string valueStr = value as string;

            if (string.IsNullOrEmpty(valueStr))
                return string.Empty;

            DateTime parsedDateTime = DateTime.Parse(valueStr, culture);

            string dateStr = parsedDateTime.ToString(parameter as string);

            return string.Format(dateStr, parsedDateTime.Day.Ordinalize());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
