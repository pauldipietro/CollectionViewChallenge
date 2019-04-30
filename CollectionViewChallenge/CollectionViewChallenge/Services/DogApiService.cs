using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.Services
{
    public static class DogApiService
    {
        private static HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }

        private static readonly HttpClient client = CreateHttpClient();

        public static async Task<List<Dog>> GetDogs()
        {
            var response = await client.GetAsync("https://api.thedogapi.com/v1/images/search?limit=50&page=1&api_key=5cb9aa6b-d6ec-4b05-95d2-5c6434b5e2b8");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Dog>>(json);
            }

            return null;
        }
    }
}
