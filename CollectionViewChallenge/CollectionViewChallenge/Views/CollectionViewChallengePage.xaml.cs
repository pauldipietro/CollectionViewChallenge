using CollectionViewChallenge.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        public CollectionViewChallengeViewModel viewModel;
        public CollectionViewChallengePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new CollectionViewChallengeViewModel();
            if (viewModel.Characters.Count == 0)
            {
                viewModel.LoadCharactersCommand.Execute(null);
                collectionViewSource.ItemsSource = viewModel.Characters;
            }
        }
    }
}