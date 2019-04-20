using System.Linq;
using CollectionViewChallenge.Models;
using CollectionViewChallenge.Services;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;

namespace CollectionViewChallenge
{
    public partial class App : Application
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        public static Member CurrentUser { get; private set; }

        public App()
        {
            InitializeComponent();

            ServiceProvider = CreateServiceProvider();

            var timelineService = App.ServiceProvider.GetRequiredService<ITimelineService>();
            CurrentUser = timelineService.Members.First();

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
