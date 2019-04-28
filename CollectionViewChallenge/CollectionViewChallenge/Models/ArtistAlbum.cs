using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CollectionViewChallenge.Models
{
    public partial class ArtistAlbum
    {
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public Item[] Items { get; set; }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }

        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Next { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("album_group", NullValueHandling = NullValueHandling.Ignore)]
        public AlbumGroup? AlbumGroup { get; set; }

        [JsonProperty("album_type", NullValueHandling = NullValueHandling.Ignore)]
        public AlbumGroup? AlbumType { get; set; }

        [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
        public Artist[] Artists { get; set; }

        [JsonProperty("available_markets", NullValueHandling = NullValueHandling.Ignore)]
        public AvailableMarket[] AvailableMarkets { get; set; }

        [JsonProperty("external_urls", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalUrls ExternalUrls { get; set; }

        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public Image[] Images { get; set; }

        [JsonIgnore]
        public Uri Cover => new Uri(this.Images[0]?.Url.ToString());

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("total_tracks", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalTracks { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public AlbumGroup? Type { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }
    }

    public partial class Artist
    {
        [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
        public ArtistElement[] Artists { get; set; }

        [JsonProperty("external_urls", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalUrls ExternalUrls { get; set; }

        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }
    }

    //public partial class ExternalUrls
    //{
    //    [JsonProperty("spotify", NullValueHandling = NullValueHandling.Ignore)]
    //    public Uri Spotify { get; set; }
    //}

    //public partial class Image
    //{
    //    [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Height { get; set; }

    //    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    //    public Uri Url { get; set; }

    //    [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Width { get; set; }
    //}

    public enum AlbumGroup { Album, AppearsOn, Compilation, Single };

    //public enum TypeEnum { Artist };

    public enum AvailableMarket { Ad, Ae, Ar, At, Au, Be, Bg, Bh, Bo, Br, Ca, Ch, Cl, Co, Cr, Cy, Cz, De, Dk, Do, Dz, Ec, Ee, Eg, Es, Fi, Fr, Gb, Gr, Gt, Hk, Hn, Hu, Id, Ie, Il, In, Is, It, Jo, Jp, Kw, Lb, Li, Lt, Lu, Lv, Ma, Mc, Mt, Mx, My, Ni, Nl, No, Nz, Om, Pa, Pe, Ph, Pl, Ps, Pt, Py, Qa, Ro, Sa, Se, Sg, Sk, Sv, Th, Tn, Tr, Tw, Us, Uy, Vn, Za };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AlbumGroupConverter.Singleton,
                AvailableMarketConverter.Singleton,
                TypeEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

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


    internal class AlbumGroupConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AlbumGroup) || t == typeof(AlbumGroup?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "album":
                    return AlbumGroup.Album;
                case "appears_on":
                    return AlbumGroup.AppearsOn;
                case "compilation":
                    return AlbumGroup.Compilation;
                case "single":
                    return AlbumGroup.Single;
            }
            throw new Exception("Cannot unmarshal type AlbumGroup");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AlbumGroup)untypedValue;
            switch (value)
            {
                case AlbumGroup.Album:
                    serializer.Serialize(writer, "album");
                    return;
                case AlbumGroup.AppearsOn:
                    serializer.Serialize(writer, "appears_on");
                    return;
                case AlbumGroup.Compilation:
                    serializer.Serialize(writer, "compilation");
                    return;
                case AlbumGroup.Single:
                    serializer.Serialize(writer, "single");
                    return;
            }
            throw new Exception("Cannot marshal type AlbumGroup");
        }

        public static readonly AlbumGroupConverter Singleton = new AlbumGroupConverter();
    }

    //internal class TypeEnumConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        if (value == "artist")
    //        {
    //            return TypeEnum.Artist;
    //        }
    //        throw new Exception("Cannot unmarshal type TypeEnum");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (TypeEnum)untypedValue;
    //        if (value == TypeEnum.Artist)
    //        {
    //            serializer.Serialize(writer, "artist");
    //            return;
    //        }
    //        throw new Exception("Cannot marshal type TypeEnum");
    //    }

    //    public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    //}

    internal class AvailableMarketConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AvailableMarket) || t == typeof(AvailableMarket?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AD":
                    return AvailableMarket.Ad;
                case "AE":
                    return AvailableMarket.Ae;
                case "AR":
                    return AvailableMarket.Ar;
                case "AT":
                    return AvailableMarket.At;
                case "AU":
                    return AvailableMarket.Au;
                case "BE":
                    return AvailableMarket.Be;
                case "BG":
                    return AvailableMarket.Bg;
                case "BH":
                    return AvailableMarket.Bh;
                case "BO":
                    return AvailableMarket.Bo;
                case "BR":
                    return AvailableMarket.Br;
                case "CA":
                    return AvailableMarket.Ca;
                case "CH":
                    return AvailableMarket.Ch;
                case "CL":
                    return AvailableMarket.Cl;
                case "CO":
                    return AvailableMarket.Co;
                case "CR":
                    return AvailableMarket.Cr;
                case "CY":
                    return AvailableMarket.Cy;
                case "CZ":
                    return AvailableMarket.Cz;
                case "DE":
                    return AvailableMarket.De;
                case "DK":
                    return AvailableMarket.Dk;
                case "DO":
                    return AvailableMarket.Do;
                case "DZ":
                    return AvailableMarket.Dz;
                case "EC":
                    return AvailableMarket.Ec;
                case "EE":
                    return AvailableMarket.Ee;
                case "EG":
                    return AvailableMarket.Eg;
                case "ES":
                    return AvailableMarket.Es;
                case "FI":
                    return AvailableMarket.Fi;
                case "FR":
                    return AvailableMarket.Fr;
                case "GB":
                    return AvailableMarket.Gb;
                case "GR":
                    return AvailableMarket.Gr;
                case "GT":
                    return AvailableMarket.Gt;
                case "HK":
                    return AvailableMarket.Hk;
                case "HN":
                    return AvailableMarket.Hn;
                case "HU":
                    return AvailableMarket.Hu;
                case "ID":
                    return AvailableMarket.Id;
                case "IE":
                    return AvailableMarket.Ie;
                case "IL":
                    return AvailableMarket.Il;
                case "IN":
                    return AvailableMarket.In;
                case "IS":
                    return AvailableMarket.Is;
                case "IT":
                    return AvailableMarket.It;
                case "JO":
                    return AvailableMarket.Jo;
                case "JP":
                    return AvailableMarket.Jp;
                case "KW":
                    return AvailableMarket.Kw;
                case "LB":
                    return AvailableMarket.Lb;
                case "LI":
                    return AvailableMarket.Li;
                case "LT":
                    return AvailableMarket.Lt;
                case "LU":
                    return AvailableMarket.Lu;
                case "LV":
                    return AvailableMarket.Lv;
                case "MA":
                    return AvailableMarket.Ma;
                case "MC":
                    return AvailableMarket.Mc;
                case "MT":
                    return AvailableMarket.Mt;
                case "MX":
                    return AvailableMarket.Mx;
                case "MY":
                    return AvailableMarket.My;
                case "NI":
                    return AvailableMarket.Ni;
                case "NL":
                    return AvailableMarket.Nl;
                case "NO":
                    return AvailableMarket.No;
                case "NZ":
                    return AvailableMarket.Nz;
                case "OM":
                    return AvailableMarket.Om;
                case "PA":
                    return AvailableMarket.Pa;
                case "PE":
                    return AvailableMarket.Pe;
                case "PH":
                    return AvailableMarket.Ph;
                case "PL":
                    return AvailableMarket.Pl;
                case "PS":
                    return AvailableMarket.Ps;
                case "PT":
                    return AvailableMarket.Pt;
                case "PY":
                    return AvailableMarket.Py;
                case "QA":
                    return AvailableMarket.Qa;
                case "RO":
                    return AvailableMarket.Ro;
                case "SA":
                    return AvailableMarket.Sa;
                case "SE":
                    return AvailableMarket.Se;
                case "SG":
                    return AvailableMarket.Sg;
                case "SK":
                    return AvailableMarket.Sk;
                case "SV":
                    return AvailableMarket.Sv;
                case "TH":
                    return AvailableMarket.Th;
                case "TN":
                    return AvailableMarket.Tn;
                case "TR":
                    return AvailableMarket.Tr;
                case "TW":
                    return AvailableMarket.Tw;
                case "US":
                    return AvailableMarket.Us;
                case "UY":
                    return AvailableMarket.Uy;
                case "VN":
                    return AvailableMarket.Vn;
                case "ZA":
                    return AvailableMarket.Za;
            }
            throw new Exception("Cannot unmarshal type AvailableMarket");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AvailableMarket)untypedValue;
            switch (value)
            {
                case AvailableMarket.Ad:
                    serializer.Serialize(writer, "AD");
                    return;
                case AvailableMarket.Ae:
                    serializer.Serialize(writer, "AE");
                    return;
                case AvailableMarket.Ar:
                    serializer.Serialize(writer, "AR");
                    return;
                case AvailableMarket.At:
                    serializer.Serialize(writer, "AT");
                    return;
                case AvailableMarket.Au:
                    serializer.Serialize(writer, "AU");
                    return;
                case AvailableMarket.Be:
                    serializer.Serialize(writer, "BE");
                    return;
                case AvailableMarket.Bg:
                    serializer.Serialize(writer, "BG");
                    return;
                case AvailableMarket.Bh:
                    serializer.Serialize(writer, "BH");
                    return;
                case AvailableMarket.Bo:
                    serializer.Serialize(writer, "BO");
                    return;
                case AvailableMarket.Br:
                    serializer.Serialize(writer, "BR");
                    return;
                case AvailableMarket.Ca:
                    serializer.Serialize(writer, "CA");
                    return;
                case AvailableMarket.Ch:
                    serializer.Serialize(writer, "CH");
                    return;
                case AvailableMarket.Cl:
                    serializer.Serialize(writer, "CL");
                    return;
                case AvailableMarket.Co:
                    serializer.Serialize(writer, "CO");
                    return;
                case AvailableMarket.Cr:
                    serializer.Serialize(writer, "CR");
                    return;
                case AvailableMarket.Cy:
                    serializer.Serialize(writer, "CY");
                    return;
                case AvailableMarket.Cz:
                    serializer.Serialize(writer, "CZ");
                    return;
                case AvailableMarket.De:
                    serializer.Serialize(writer, "DE");
                    return;
                case AvailableMarket.Dk:
                    serializer.Serialize(writer, "DK");
                    return;
                case AvailableMarket.Do:
                    serializer.Serialize(writer, "DO");
                    return;
                case AvailableMarket.Dz:
                    serializer.Serialize(writer, "DZ");
                    return;
                case AvailableMarket.Ec:
                    serializer.Serialize(writer, "EC");
                    return;
                case AvailableMarket.Ee:
                    serializer.Serialize(writer, "EE");
                    return;
                case AvailableMarket.Eg:
                    serializer.Serialize(writer, "EG");
                    return;
                case AvailableMarket.Es:
                    serializer.Serialize(writer, "ES");
                    return;
                case AvailableMarket.Fi:
                    serializer.Serialize(writer, "FI");
                    return;
                case AvailableMarket.Fr:
                    serializer.Serialize(writer, "FR");
                    return;
                case AvailableMarket.Gb:
                    serializer.Serialize(writer, "GB");
                    return;
                case AvailableMarket.Gr:
                    serializer.Serialize(writer, "GR");
                    return;
                case AvailableMarket.Gt:
                    serializer.Serialize(writer, "GT");
                    return;
                case AvailableMarket.Hk:
                    serializer.Serialize(writer, "HK");
                    return;
                case AvailableMarket.Hn:
                    serializer.Serialize(writer, "HN");
                    return;
                case AvailableMarket.Hu:
                    serializer.Serialize(writer, "HU");
                    return;
                case AvailableMarket.Id:
                    serializer.Serialize(writer, "ID");
                    return;
                case AvailableMarket.Ie:
                    serializer.Serialize(writer, "IE");
                    return;
                case AvailableMarket.Il:
                    serializer.Serialize(writer, "IL");
                    return;
                case AvailableMarket.In:
                    serializer.Serialize(writer, "IN");
                    return;
                case AvailableMarket.Is:
                    serializer.Serialize(writer, "IS");
                    return;
                case AvailableMarket.It:
                    serializer.Serialize(writer, "IT");
                    return;
                case AvailableMarket.Jo:
                    serializer.Serialize(writer, "JO");
                    return;
                case AvailableMarket.Jp:
                    serializer.Serialize(writer, "JP");
                    return;
                case AvailableMarket.Kw:
                    serializer.Serialize(writer, "KW");
                    return;
                case AvailableMarket.Lb:
                    serializer.Serialize(writer, "LB");
                    return;
                case AvailableMarket.Li:
                    serializer.Serialize(writer, "LI");
                    return;
                case AvailableMarket.Lt:
                    serializer.Serialize(writer, "LT");
                    return;
                case AvailableMarket.Lu:
                    serializer.Serialize(writer, "LU");
                    return;
                case AvailableMarket.Lv:
                    serializer.Serialize(writer, "LV");
                    return;
                case AvailableMarket.Ma:
                    serializer.Serialize(writer, "MA");
                    return;
                case AvailableMarket.Mc:
                    serializer.Serialize(writer, "MC");
                    return;
                case AvailableMarket.Mt:
                    serializer.Serialize(writer, "MT");
                    return;
                case AvailableMarket.Mx:
                    serializer.Serialize(writer, "MX");
                    return;
                case AvailableMarket.My:
                    serializer.Serialize(writer, "MY");
                    return;
                case AvailableMarket.Ni:
                    serializer.Serialize(writer, "NI");
                    return;
                case AvailableMarket.Nl:
                    serializer.Serialize(writer, "NL");
                    return;
                case AvailableMarket.No:
                    serializer.Serialize(writer, "NO");
                    return;
                case AvailableMarket.Nz:
                    serializer.Serialize(writer, "NZ");
                    return;
                case AvailableMarket.Om:
                    serializer.Serialize(writer, "OM");
                    return;
                case AvailableMarket.Pa:
                    serializer.Serialize(writer, "PA");
                    return;
                case AvailableMarket.Pe:
                    serializer.Serialize(writer, "PE");
                    return;
                case AvailableMarket.Ph:
                    serializer.Serialize(writer, "PH");
                    return;
                case AvailableMarket.Pl:
                    serializer.Serialize(writer, "PL");
                    return;
                case AvailableMarket.Ps:
                    serializer.Serialize(writer, "PS");
                    return;
                case AvailableMarket.Pt:
                    serializer.Serialize(writer, "PT");
                    return;
                case AvailableMarket.Py:
                    serializer.Serialize(writer, "PY");
                    return;
                case AvailableMarket.Qa:
                    serializer.Serialize(writer, "QA");
                    return;
                case AvailableMarket.Ro:
                    serializer.Serialize(writer, "RO");
                    return;
                case AvailableMarket.Sa:
                    serializer.Serialize(writer, "SA");
                    return;
                case AvailableMarket.Se:
                    serializer.Serialize(writer, "SE");
                    return;
                case AvailableMarket.Sg:
                    serializer.Serialize(writer, "SG");
                    return;
                case AvailableMarket.Sk:
                    serializer.Serialize(writer, "SK");
                    return;
                case AvailableMarket.Sv:
                    serializer.Serialize(writer, "SV");
                    return;
                case AvailableMarket.Th:
                    serializer.Serialize(writer, "TH");
                    return;
                case AvailableMarket.Tn:
                    serializer.Serialize(writer, "TN");
                    return;
                case AvailableMarket.Tr:
                    serializer.Serialize(writer, "TR");
                    return;
                case AvailableMarket.Tw:
                    serializer.Serialize(writer, "TW");
                    return;
                case AvailableMarket.Us:
                    serializer.Serialize(writer, "US");
                    return;
                case AvailableMarket.Uy:
                    serializer.Serialize(writer, "UY");
                    return;
                case AvailableMarket.Vn:
                    serializer.Serialize(writer, "VN");
                    return;
                case AvailableMarket.Za:
                    serializer.Serialize(writer, "ZA");
                    return;
            }
            throw new Exception("Cannot marshal type AvailableMarket");
        }

        public static readonly AvailableMarketConverter Singleton = new AvailableMarketConverter();
    }
}