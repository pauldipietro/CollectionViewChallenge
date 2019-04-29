using CollectionViewChallenge.Models;
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
        public CollectionViewChallengePage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<ServicePageViewModel, int>(this, "ScrollToSelectedService", ScrollToSelectedService);
        }

        async void ScrollToSelectedService(ServicePageViewModel sender, int arg)
        {
            ServiceCollection.ScrollTo(arg, position: ScrollToPosition.Center);
        }
    }
}