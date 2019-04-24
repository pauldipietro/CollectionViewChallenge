using System;
using CollectionViewChallenge.Enum;
using CollectionViewChallenge.Models;
using Xamarin.Forms;

namespace CollectionViewChallenge.Templates
{
    public class PodcastCellDataTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate PodcastStandard;

        public PodcastCellDataTemplateSelector()
        {
            PodcastStandard = new DataTemplate(typeof(PodcastStandard));
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
                    throw new NotImplementedException();

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