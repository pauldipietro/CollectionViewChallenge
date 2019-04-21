using CollectionViewChallenge.Enums;
using CollectionViewChallenge.Models;
using CollectionViewChallenge.Templates.Netflix;
using Xamarin.Forms;

namespace CollectionViewChallenge.Templates
{
    public class NetflixTemplate : DataTemplateSelector
    {
        private readonly DataTemplate _featured;
        private readonly DataTemplate _standard;
        private readonly DataTemplate _playable;

        public NetflixTemplate()
        {
            _featured = new DataTemplate(typeof(Featured));
            _standard = new DataTemplate(typeof(Standard));
            _playable = new DataTemplate(typeof(Playable));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var movie = item as MovieModel;

            if (movie.Type == NetflixCoverType.Featured)
                return _featured;

            if (movie.Type == NetflixCoverType.Standard)
                return _standard;

            if (movie.Type == NetflixCoverType.Playable)
                return _playable;

            return _standard;
        }
    }
}
