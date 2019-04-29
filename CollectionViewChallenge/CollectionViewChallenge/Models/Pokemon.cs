using System.Collections.Generic;
using Newtonsoft.Json;
using CollectionViewChallenge.Class;

namespace CollectionViewChallenge.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public Name name { get; set; }
        public List<string> type { get; set; }

        [JsonProperty("base")]
        public Base _base { get; set; }

        public string ImageURL
        {
            get
            {
                var num = id.ToString().PadLeft(3, '0');
                return $"https://raw.githubusercontent.com/fanzeyi/pokemon.json/master/images/{num}{name.english}.png";
            }
        }

        public string Types => string.Join(", ", type);

        public double HP => _base.HP * Constants.factor;
        public double Attack => _base.Attack * Constants.factor;
        public double Defense => _base.Defense * Constants.factor;
        public double SpAttack => _base.SpAttack * Constants.factor;
        public double SpDefense => _base.SpDefense * Constants.factor;
        public double Speed => _base.Speed * Constants.factor;
    }

    public class Name
    {
        public string english { get; set; }
        public string japanese { get; set; }
        public string chinese { get; set; }
    }

    public class Base
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        [JsonProperty("Sp. Attack")]
        public int SpAttack { get; set; }

        [JsonProperty("Sp. Defense")]
        public int SpDefense { get; set; }

        public int Speed { get; set; }
    }
}
