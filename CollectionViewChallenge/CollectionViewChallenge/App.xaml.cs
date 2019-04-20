using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CollectionViewChallenge.Views;
using Microsoft.Extensions.DependencyInjection;
using CollectionViewChallenge.Services;

namespace CollectionViewChallenge
{
    public partial class App : Application
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        public App()
        {
            InitializeComponent();

            ServiceProvider = CreateServiceProvider();

            MainPage = new AppShell();
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

        private ServiceProvider CreateServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddScoped<ITimelineService, TimelineService>();
            return services.BuildServiceProvider();
        }
    }
}
