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
	public partial class MainPage : ContentPage
	{
        MovieViewModel mv;

		public MainPage ()
		{
			InitializeComponent ();
            //mv = new MovieViewModel();
           // BindingContext = mv;
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

          //  await mv.GetMoviesCommand();

            await Task.Delay(8000);
        }


    }

}