using System;
using CollectionViewChallenge.Enum;
using CollectionViewChallenge.Models;
using Xamarin.Forms;

namespace CollectionViewChallenge.Templates
{
    public class PodcastCellDataTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate PodcastStandard;
        private readonly DataTemplate PodcastNew;

        public PodcastCellDataTemplateSelector()
        {
            PodcastStandard = new DataTemplate(typeof(PodcastStandard));
            PodcastNew = new DataTemplate(typeof(PodcastNew));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item == null)
                return null;

            if (!(item is Podcast))
                return null;

            var podcast = item as Podcast;
            switch (podcast.CellType)
            {
                case PodcastCellType.New:
                    return PodcastNew;

                case PodcastCellType.Standard:
                    return PodcastStandard;

                case PodcastCellType.Personalized:
                    throw new NotImplementedException();

                default:
                    return PodcastStandard;
            }
        }
    }
}