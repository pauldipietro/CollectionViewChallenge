using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CollectionViewChallenge.Models;
using Newtonsoft.Json;

namespace CollectionViewChallenge.Services
{
    public class ApiServices
    {
        private static string GetAllMediaApiUrl = "https://churchplusapi.azurewebsites.net/api/MediaServiceApiController/GetMediaFiles";
        private static string appkey = App.AppKey;

        public static async Task<List<Audio>> GetAudios()
        {



            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("CID", appkey);

            var response = await client.GetAsync(GetAllMediaApiUrl);
            HttpContent httpContent = response.Content;
            var json = await httpContent.ReadAsStringAsync();

            var audios = JsonConvert.DeserializeObject<List<Audio>>(json);
            return audios;
        }

    }
}
