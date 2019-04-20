using System;
using System.Collections.Generic;
using CollectionViewChallenge.ViewModels;
using Xamarin.Forms;

namespace CollectionViewChallenge.Views
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            this.BindingContext = new ChallengeViewModel();
        }
    }
}
