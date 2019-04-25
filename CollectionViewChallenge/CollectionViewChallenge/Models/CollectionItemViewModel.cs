using Xamarin.Forms;

namespace CollectionViewChallenge.Models
{
    public class CollectionItemViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ImageSource CoverUrl { get; set; }
        public GridLength DescRowHeight { get; set; }
    }
}
