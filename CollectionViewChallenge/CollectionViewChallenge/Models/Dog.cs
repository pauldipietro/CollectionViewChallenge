using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CollectionViewChallenge.Models
{
    public class Dog
    {
        public Breed[] breeds { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public string breed => string.Join(", ", breeds.Select(x => x.name));
        public string temperament => string.Join(", ", breeds.Select(x => x.temperament));
    }

    public class Breed
    {
        public Weight weight { get; set; }
        public Height height { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string bred_for { get; set; }
        public string breed_group { get; set; }
        public string life_span { get; set; }
        public string temperament { get; set; }
        public string origin { get; set; }
        public string country_code { get; set; }
    }

    public class Weight
    {
        public string imperial { get; set; }
        public string metric { get; set; }
    }

    public class Height
    {
        public string imperial { get; set; }
        public string metric { get; set; }
    }

}
