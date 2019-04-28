using System;
using Newtonsoft.Json;

namespace CollectionViewChallenge.Models
{
    //public class Artist
    //{
    //    [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
    //    public ArtistElement[] Artists { get; set; }
    //}

    public class ArtistElement
    {
        [JsonProperty("external_urls", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalUrls ExternalUrls { get; set; }

        [JsonProperty("followers", NullValueHandling = NullValueHandling.Ignore)]
        public Followers Followers { get; set; }

        [JsonProperty("genres", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Genres { get; set; }

        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public Image[] Images { get; set; }

        [JsonIgnore]
        public Uri Picture => new Uri(this.Images[0]?.Url.ToString());

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("popularity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Popularity { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }
    }

    public class ExternalUrls
    {
        [JsonProperty("spotify", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Spotify { get; set; }
    }

    public class Followers
    {
        [JsonProperty("href")]
        public object Href { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }
    }

    public class Image
    {
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }
    }

    public enum TypeEnum { Artist };

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            TypeEnumConverter.Singleton,
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "artist")
            {
                return TypeEnum.Artist;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.Artist)
            {
                serializer.Serialize(writer, "artist");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}
