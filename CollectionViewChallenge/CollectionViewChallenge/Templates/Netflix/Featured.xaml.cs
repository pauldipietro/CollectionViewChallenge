using Xamarin.Forms;

namespace CollectionViewChallenge.Templates.Netflix
{
    public partial class Featured : ContentView
    {
        public Featured()
        {
            InitializeComponent();
            featuredPhoto.WidthRequest = Application.Current.MainPage.Width;
            shadow.WidthRequest = Application.Current.MainPage.Width;
        }
    }
}
