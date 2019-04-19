using System;
namespace CollectionViewChallenge.Models
{
    public class Audio
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MediaType { get; set; }
        public bool? IsFree { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }
        public string ImagePath { get; set; }

        public string FilePath { get; set; }
        public int? ViewCount { get; set; }
        public int? DownloadCount { get; set; }
        public string Price { get; set; }
    }
}
