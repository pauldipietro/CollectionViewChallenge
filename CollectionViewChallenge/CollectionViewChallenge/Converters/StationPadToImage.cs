using System;
using System.Globalization;
using Xamarin.Forms;

namespace CollectionViewChallenge.Converters
{
    internal class StationPadToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return String.Empty;
            }

            string pad = ((string)value).Trim().ToLower();
            switch (pad)
            {
                case "large":
                case "station":
                    return "resource://CollectionViewChallenge.Resources.coriolis.orange.svg";
                case "large (planet)":
                case "large(planet)":
                case "planetary":
                    return "resource://CollectionViewChallenge.Resources.surface-port.orange.svg";
                case "medium":
                case "outpost":
                    return "resource://CollectionViewChallenge.Resources.outpost.orange.svg";
                default:
                    return String.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
