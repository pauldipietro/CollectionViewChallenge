using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CollectionViewChallenge
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
        }
    }
}
