using System;
using System.Globalization;
using Xamarin.Forms;

namespace CollectionViewChallenge.Converters
{
    internal class FactionToLogo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return String.Empty;
            }

            string faction = ((string)value).Trim().ToLower();
            switch (faction)
            {
                case "alliance":
                    return "resource://CollectionViewChallenge.Resources.alliance.green.svg";
                case "empire":
                    return "resource://CollectionViewChallenge.Resources.empire.blue.svg";
                case "federation":
                    return "resource://CollectionViewChallenge.Resources.federation.red.svg";
                case "independent":
                case "independant": // Uranius can't spell
                    return "resource://CollectionViewChallenge.Resources.independent.orange.svg";
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
