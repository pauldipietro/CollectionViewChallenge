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
        public MovieViewModel viewModel;
        public CollectionViewChallengePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MovieViewModel();
            if(viewModel.Movies.Count==0)
            {
                viewModel.GetMoviesCommand.Execute(null);
                movieViewSource.ItemsSource = viewModel.Movies;
            }
        }
    }
}