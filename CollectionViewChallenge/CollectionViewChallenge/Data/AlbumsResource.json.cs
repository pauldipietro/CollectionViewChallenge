using System;
using System.IO;
using System.Reflection;
using CollectionViewChallenge.Models;
using Newtonsoft.Json;

namespace CollectionViewChallenge.Data
{
    public class AlbumsResource
    {
        public Item[] GetAlbums()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(AlbumsResource)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("CollectionViewChallenge.Data.AlbumsResource.json");

            Item[] rootobject;
            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<ArtistAlbum>(json);
                rootobject = items.Items;
            }
            return rootobject;
        }
    }
}
