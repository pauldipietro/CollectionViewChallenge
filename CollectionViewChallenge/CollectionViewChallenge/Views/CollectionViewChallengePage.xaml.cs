using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        public List<string> NewShows { get; set; }
        public List<string> PopularShows { get; set; }

        public CollectionViewChallengePage()
        {
            InitializeComponent();

            NewShows = new List<string>();
            PopularShows = new List<string>();

            NewShows.Add("circular1.jpg");
            NewShows.Add("circular2.jpg");
            NewShows.Add("circular3.jpg");
            NewShows.Add("circular4.jpg");
            NewShows.Add("circular5.jpg");
            NewShows.Add("circular6.jpg");
            NewShows.Add("circular7.jpg");

            PopularShows.Add("circular7.jpg");
            PopularShows.Add("circular6.jpg");
            PopularShows.Add("circular5.jpg");
            PopularShows.Add("circular4.jpg");
            PopularShows.Add("circular3.jpg");
            PopularShows.Add("circular2.jpg");
            PopularShows.Add("circular1.jpg");

            newShows.ItemsSource = NewShows;
            popularShows.ItemsSource = PopularShows;
            netflixPopular.ItemsSource = NewShows;
        }
    }
}