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
        PokemonViewModel vm;

        public CollectionViewChallengePage()
        {
            InitializeComponent();
            vm = new PokemonViewModel();
            BindingContext = vm;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await vm.LoadIceDarkPokedex();

            await Task.Delay(5000);

            var articuno = vm.IcePokemonList.Where(x => x.name.english == "Articuno").FirstOrDefault();
            collectionViewIce.ScrollTo(articuno, position: ScrollToPosition.Center, animate: false);
        }
    }
}