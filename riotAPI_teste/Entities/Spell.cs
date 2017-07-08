using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste.Entities
{
    class Spell
    {
        [JsonProperty("name")]
        public string name;
        [JsonProperty("description")]
        public string description;
        [JsonProperty("sanitizedDescription")]
        public string sanitizedDescription;
        [JsonProperty("toolTip")]
        public string toolTip;
        [JsonProperty("sanitizedToolTip")]
        public string sanitizedToolTip;
        [JsonProperty("levelTip")]
        public LevelTip[] levelTip;
        [JsonProperty("image")]
        public Image image;
        [JsonProperty("resource")]
        public string resource;
        [JsonProperty("maxRank")]
        public int maxRank;
        [JsonProperty("cost")]
        public int[] cost;
        [JsonProperty("costType")]
        public string costType;
        [JsonProperty("costBurn")]
        public string costBurn;
        [JsonProperty("coolDown")]
        public int[] coolDown;
        [JsonProperty("coolDownBurn")]
        public string coolDownBurn;
        [JsonProperty("effect")]
        public Dictionary<int, int> effect;
        [JsonProperty("effectBurn")]
        public string[] effectBurn;
        [JsonProperty("vars")]
        public Vars[] vars;
        [JsonProperty("range")]
        public int[] range;
        [JsonProperty("rangeBurn")]
        public string rangeBurn;
        [JsonProperty("key")]
        public string key;
    }
}
