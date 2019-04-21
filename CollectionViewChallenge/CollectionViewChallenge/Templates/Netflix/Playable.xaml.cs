using Xamarin.Forms;

namespace CollectionViewChallenge.Templates.Netflix
{
    public partial class Playable : ContentView
    {
        public Playable()
        {
            InitializeComponent();
            playablePhoto.WidthRequest = Application.Current.MainPage.Width;
        }
    }
}
