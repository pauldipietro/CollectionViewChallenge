using CollectionViewChallenge.ViewModels;
using Xamarin.Forms;

namespace CollectionViewChallenge.Views
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = new PlayersViewModel();
        }
    }
}
