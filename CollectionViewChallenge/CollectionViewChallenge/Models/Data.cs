using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewChallenge.Models
{
    public class Data
    {
        [JsonProperty("results")]
        public List<Character> Characters { get; set; }
    }
}
