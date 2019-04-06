using CollectionViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        public CollectionViewChallengePage()
        {
            InitializeComponent();
            BindingContext = new PlayersViewModel();
        }

        void Vertical_Clicked(object sender, System.EventArgs e)
        {
            PlayersCollectionView.ItemsLayout = ListItemsLayout.VerticalList;
            //PlayersCollectionView.rel
            //PlayersCollectionView.
        }

        void GridVertical_Clicked(object sender, System.EventArgs e)
        {
            PlayersCollectionView.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);
        }

        void GridHorizontal_Clicked(object sender, System.EventArgs e)
        {
            PlayersCollectionView.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Horizontal);
        }
    }
}