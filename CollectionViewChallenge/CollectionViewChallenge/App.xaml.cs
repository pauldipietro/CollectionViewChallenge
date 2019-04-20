using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CollectionViewChallenge.Views;

namespace CollectionViewChallenge
{
    public partial class App : Application
    {
        public static INavigation Navigation;

        public App()
        {
            InitializeComponent();

//#if DEBUG
//            HotReloader.Current.Start(this);
//#endif

            MainPage = new NavigationPage(new ListViewPage());
            Navigation = MainPage.Navigation;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
