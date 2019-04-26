using System;
using Xamarin.Essentials;
using Xamarin.Forms.Maps;

namespace CollectionViewChallenge.Models
{
    public class StatisticsDetail
    {
        public string DisplayValue { get; set; }
        public string DisplayDescription { get; set; }

        public string Icon { get; set; }
    }

    public class KudosDetail
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }

    public class Location
    {
        public string Description { get; set;  }
        public Position Position { get; set; }
    }
}