using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CollectionViewChallenge.Views;

namespace CollectionViewChallenge
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        public static string AppKey { get { return "b3c8f22b-079c-4255-ab53-86f17cdcfac6"; } }
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
