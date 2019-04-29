using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using CollectionViewChallenge.Models;
using Newtonsoft.Json;

namespace CollectionViewChallenge.Services
{
    public static class PokemonApiService
    {
        private static readonly HttpClient client = CrearHttpClient();

        private static HttpClient CrearHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }

        public async static Task<List<Pokemon>> GetPokemon()
        {
            var response = await client.GetAsync("https://raw.githubusercontent.com/fanzeyi/pokemon.json/master/pokedex.json");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<Pokemon>>(json);
                return list;
            }

            return default(List<Pokemon>);
        }
    }
}
