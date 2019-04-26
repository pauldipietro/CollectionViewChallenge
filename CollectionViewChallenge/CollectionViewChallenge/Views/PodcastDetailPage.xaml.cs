using System;
using System.Collections.Generic;
using CollectionViewChallenge.Models;
using Xamarin.Forms;

namespace CollectionViewChallenge.Views
{
    public partial class PodcastDetailPage : ContentPage
    {
        public PodcastDetailPage(Podcast selected)
        {
            InitializeComponent();
            BindingContext = selected;
        }
    }
}
