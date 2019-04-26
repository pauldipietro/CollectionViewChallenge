using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public CollectionViewChallengePage()
        {
            InitializeComponent();
            BindingContext = new PodcastCollectionViewModel();
            UpdateSelectionDataAsync(Enumerable.Empty<Podcast>(), Enumerable.Empty<Podcast>());
        }

        void Handle_SelectionChanged(object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            UpdateSelectionDataAsync(e.PreviousSelection, e.CurrentSelection);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationProxy.Inner = App.NavigationRoot?.NavigationProxy;
        }

        public async Task UpdateSelectionDataAsync(IEnumerable<object> previousSelection, IEnumerable<object> currentSelection)
        {
            var selected = (currentSelection.FirstOrDefault() as Podcast);
            await App.NavigateToAsync(new PodcastDetailPage(selected));
        }

        void CollectionView2_Tapped(object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            PodcastSelectedAsync(e.PreviousSelection, e.CurrentSelection);
        }

        public async Task PodcastSelectedAsync(IReadOnlyList<object> previousSelection, IReadOnlyList<object> currentSelection)
        {
            var selected = (currentSelection.FirstOrDefault() as Podcast);
            await App.NavigateToAsync(new PodcastDetailPage(selected));
        }
    }
}