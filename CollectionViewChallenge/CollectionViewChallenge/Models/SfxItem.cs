using System;
namespace CollectionViewChallenge.Models
{
    public class SfxItem
    {
        public object id { get; set; }
        public string name { get; set; }
        public string file { get; set; }
        public int category { get; set; }
        public int likeCount { get; set; }
        public bool enabled { get; set; }
    }
}
