using Xamarin.Forms;

namespace CollectionViewChallenge.Models
{
    public class SnapHorizontalList : ListItemsLayout
    {
        public SnapHorizontalList() : base(ItemsLayoutOrientation.Horizontal)
        {
            SnapPointsType = SnapPointsType.Mandatory;
            SnapPointsAlignment = SnapPointsAlignment.Center;
        }
    }
}
