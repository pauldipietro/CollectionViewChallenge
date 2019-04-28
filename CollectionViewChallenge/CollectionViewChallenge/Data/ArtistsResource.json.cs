using System;
using System.IO;
using System.Reflection;
using CollectionViewChallenge.Models;
using Newtonsoft.Json;

namespace CollectionViewChallenge.Data
{
    public class ArtistsResource
    {
        public ArtistElement[] GetArtists()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(ArtistElement)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("CollectionViewChallenge.Data.ArtistsResource.json");

            ArtistElement[] rootobject;
            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Artist>(json);
                rootobject = items.Artists;
            }
            return rootobject;
        }
    }
}
