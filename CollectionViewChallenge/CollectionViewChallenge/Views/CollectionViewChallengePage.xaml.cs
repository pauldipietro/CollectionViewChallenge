using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
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
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadItems();
        }

        private async void LoadItems()
        {
            // cargando la lista de elementos de rss
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://www.excelsior.com.mx/rss.xml");
                if (response.IsSuccessStatusCode)
                {
                    string rssFeedList = await response.Content.ReadAsStringAsync();
                    clvRssItems.ItemsSource = await ParseFeed(rssFeedList);
                    //lstRssItems.ItemsSource = await ParseFeed(rssFeedList);
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Rss Feed", "Algo falló", "Aceptar");
                }
            }
        }

        private async Task<List<RssFeedItem>> ParseFeed(string rss)
        {
            return await Task.Run(() =>
            {
                var xdoc = XDocument.Parse(rss);
                var id = 0;
                return (from item in xdoc.Descendants("item")
                        select new RssFeedItem
                        {
                            Title = (string)item.Element("title"),
                            Description = (string)item.Element("description"),
                            Link = (string)item.Element("link"),
                            PublishDate = (string)item.Element("pubDate"),
                            AuthorEmail = (string)item.Element("author"),
                            Id = id++
                        }).ToList();
            });
        }
    }
}
