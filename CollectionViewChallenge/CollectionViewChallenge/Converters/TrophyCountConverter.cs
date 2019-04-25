using CollectionViewChallenge.Models;
using CollectionViewChallenge.Resources.Translations;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace CollectionViewChallenge.Converters
{
    public class TrophyCountConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            GameModel game = value as GameModel;
            if (game == null)
                return string.Empty;

            if (game.EarnedTrophies.Total == game.Trophies.Total)
                return string.Format(AppResources.AllTrophyCountText, game.Trophies.Total);

            return string.Format(AppResources.TrophyCountText, game.EarnedTrophies.Total, game.Trophies.Total);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
