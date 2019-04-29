using System;
using System.Globalization;
using Xamarin.Forms;
namespace CollectionViewChallenge.Converters {
    public class RupiahFormatConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            long curval = System.Convert.ToInt64(value);
            if (curval == -1) return "-";
            var dd = curval.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID"));
            return ("IDR " + dd.ToLower().Replace("rp", "")).Trim();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            var dd = (value is long ? (long)value : 0).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID"));
            return dd.ToLower().Replace("rp", "");
        }
    }
}
