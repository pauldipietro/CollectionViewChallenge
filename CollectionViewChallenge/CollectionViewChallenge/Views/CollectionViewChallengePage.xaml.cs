using System;
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
        private Shell _shell;

        public CollectionViewChallengePage()
        {
            InitializeComponent();
            BindingContext = new CollectionViewChallengeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _shell = (Shell)Application.Current.MainPage;
        }

        private double _lastPositionYScroll = 0;

        private void AfterScroll(object sender, ScrolledEventArgs e)
        {
            bool hasNavigationBar = true;

            if (IsScrollYGreaterThanLastPosition(e.ScrollY))
                hasNavigationBar = false;

            _lastPositionYScroll = e.ScrollY;
            Shell.SetNavBarIsVisible(this, hasNavigationBar);
        }

        private bool IsScrollYGreaterThanLastPosition(double scrollY)
        {
            if (IsScrollingAtStart(scrollY))
                return false;

            if (IsScrollingAtEnd(scrollY))
                return false;

            return IsScrollingDown(scrollY);
        }

        private bool IsScrollingAtStart(double scrollY)
        {
            return scrollY <= 0;
        }

        private bool IsScrollingAtEnd(double scrollY)
        {
            var height = scroll.Content.Height - _shell.Height;
            return scrollY >= height;
        }

        private bool IsScrollingDown(double scrollY)
        {
            return scrollY > _lastPositionYScroll;
        }
    }
}