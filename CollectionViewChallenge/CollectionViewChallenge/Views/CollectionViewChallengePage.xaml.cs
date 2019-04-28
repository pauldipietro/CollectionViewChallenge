using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewChallenge.Models;
using CollectionViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        CollectionViewChallengeViewModel viewModel;

        public CollectionViewChallengePage()
        {
            InitializeComponent();
            BindingContext = new CollectionViewChallengeViewModel();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            viewModel = BindingContext as CollectionViewChallengeViewModel;
            if (viewModel == null)
                return;
        }

        void Handle_SelectionChanged(object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            //string previous = (e.PreviousSelection.FirstOrDefault() as ArtistElement)?.Id;
            string current = (e.CurrentSelection.FirstOrDefault() as ArtistElement)?.Id;

            var source = viewModel.Albums
                .Where(ab => ab.Artists.Any(art => art.Id == current))
                .Distinct();

            bodyCollectionView.ItemsSource = source;
        }
    }
}