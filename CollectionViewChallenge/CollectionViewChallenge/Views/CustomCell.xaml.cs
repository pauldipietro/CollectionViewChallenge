using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ContextMenu;

namespace CollectionViewChallenge.Views
{
    public partial class CustomCell : SideActionBarCell
    {
        public CustomCell()
        {
            InitializeComponent();
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            await button.ScaleTo(1.2);
            await button.ScaleTo(1);
            Device.BeginInvokeOnMainThread(() => ForceClose());
        }

        private void OnOpenClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            Device.BeginInvokeOnMainThread(() => ForceOpen());
        }
    }
}
