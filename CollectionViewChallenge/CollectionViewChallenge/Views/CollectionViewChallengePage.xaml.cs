using CollectionViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        private readonly CollectionViewChallengeViewModel _vm;

        public CollectionViewChallengePage()
        {
            InitializeComponent();

            BindingContext = new CollectionViewChallengeViewModel();
            _vm = BindingContext as CollectionViewChallengeViewModel;

            _vm.InitializeView();
        }
    }
}