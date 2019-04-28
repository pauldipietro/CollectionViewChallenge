using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CollectionViewChallenge.ViewModels;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        public CollectionViewChallengePage()
        {
            InitializeComponent();
            BindingContext = new CollectionViewChallengeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DaysCollectionView.ScrollTo(DateTime.Now.Day, position: ScrollToPosition.MakeVisible);
        }
    }
}