using CollectionViewChallenge.Models;
using CollectionViewChallenge.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(WebDataService))]
namespace CollectionViewChallenge.Services
{
    public class WebDataService : IDataService
    {

        HttpClient httpClient;

        HttpClient Client => httpClient ?? (httpClient = new HttpClient());

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            var json = await Client.GetStringAsync("https://raw.githubusercontent.com/BryanOroxon/CollectionViewChallenge/master/CollectionViewChallenge/CollectionViewChallenge/Data/moviedata.json");
            //var json = await Client.GetStringAsync("https://blobluis.blob.core.windows.net/data/moviedata.json");
            var all = Movie.FromJson(json);
            return all;
        }
    }
}
