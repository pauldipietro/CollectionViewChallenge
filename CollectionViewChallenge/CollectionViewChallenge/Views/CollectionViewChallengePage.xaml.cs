using System;
using System.Linq;
using ContextMenu;
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
            SampleList.ItemsSource = Enumerable.Range(0, 300);
        }

        protected BaseActionViewCell GetParent(Button button, Element parent)
        {
            if (!(parent is BaseActionViewCell actionViewCell))
            {
                actionViewCell = GetParent(button, parent.Parent);
            }

            return actionViewCell;
        }

        private void OnClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            DisplayAlert($"{button.CommandParameter} clicked", null, "OK");

            Device.BeginInvokeOnMainThread(() => GetParent(button, button.Parent).ForceClose());
        }

        private void OnOpenClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            Device.BeginInvokeOnMainThread(() => GetParent(button, button.Parent).ForceOpen());
        }
    }
}