using System;
using System.Collections.Generic;
using CollectionViewChallenge.ViewModels;
using Xamarin.Forms;

namespace CollectionViewChallenge.Views
{
    public partial class CollectionViewPage : ContentPage
    {
        public CollectionViewPage()
        {
            InitializeComponent();
            this.BindingContext = new ChallengeViewModel();
        }
    }
}
