﻿using CollectionViewChallenge.ViewModels;
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

            BindingContext = new PageViewModel();
        }
    }
}