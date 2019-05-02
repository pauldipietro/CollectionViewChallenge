﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewChallenge.ViewModels;
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

            BindingContext = new BlogViewModel();
        }
    }
}