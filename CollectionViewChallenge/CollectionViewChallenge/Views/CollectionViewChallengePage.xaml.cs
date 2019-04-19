using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CollectionViewChallenge.Services;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        public CollectionViewChallengePage()
        {
            InitializeComponent();
            populate();
        }

        public async void populate()
        {
            try
            {

                indicator.IsVisible = true;
                indicator.IsEnabled = true;
                indicator.IsRunning = true;
                var audio = await ApiServices.GetAudios();
                var freeaudiolist = audio.Where((arg) => arg.IsFree == true);
                free.ItemsSource = freeaudiolist;

                var paidaudio = audio.Where((arg) => arg.IsFree == false);
                paid.ItemsSource = paidaudio;

                indicator.IsVisible = false;
                indicator.IsEnabled = false;
                indicator.IsRunning = false;
            }
            catch (Exception ex)
            {

            }

        }
    }
}