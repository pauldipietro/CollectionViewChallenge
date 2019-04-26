using System;
using System.Collections.Generic;
using CollectionViewChallenge.Views;
using Xamarin.Forms;

namespace CollectionViewChallenge
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            App.NavigationRoot = this;
        }
    }
}
