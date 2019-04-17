using CollectionViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        private readonly FortifyViewModel fort = new FortifyViewModel();

        public CollectionViewChallengePage()
        {
            InitializeComponent();
            BindingContext = fort;
        }

        protected override void OnAppearing()
        {
            fort.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            fort.OnDisappearing();
        }
    }
}