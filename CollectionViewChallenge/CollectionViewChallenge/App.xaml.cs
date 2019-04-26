using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CollectionViewChallenge.Views;
using System.Threading.Tasks;

namespace CollectionViewChallenge
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

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

        private static NavigableElement navigationRoot;
        public static NavigableElement NavigationRoot
        {
            get => GetShellSection(navigationRoot) ?? navigationRoot;
            set => navigationRoot = value;
        }

        internal static ShellSection GetShellSection(Element element)
        {
            if (element == null)
            {
                return null;
            }

            var parent = element;
            var parentSection = parent as ShellSection;

            while (parentSection == null && parent != null)
            {
                parent = parent.Parent;
                parentSection = parent as ShellSection;
            }

            return parentSection;
        }

        internal static async Task NavigateToAsync(Page page)
        {
            await NavigationRoot.Navigation.PushAsync(page, true).ConfigureAwait(false);
        }
    }
}
