using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace riotAPI_teste
{
    public class Spell
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("sanitizedDescription")]
        public string sanitizedDescription { get; set; }
        [JsonProperty("toolTip")]
        public string toolTip { get; set; }
        [JsonProperty("sanitizedToolTip")]
        public string sanitizedToolTip { get; set; }
        [JsonProperty("levelTip")]
        public LevelTip levelTip { get; set; }
        [JsonProperty("image")]
        public Image image { get; set; }
        [JsonProperty("resource")]
        public string resource { get; set; }
        [JsonProperty("maxRank")]
        public int maxRank { get; set; }
        [JsonProperty("cost")]
        public int[] cost { get; set; }
        [JsonProperty("costType")]
        public string costType { get; set; }
        [JsonProperty("costBurn")]
        public string costBurn { get; set; }
        [JsonProperty("coolDown")]
        public string[] coolDown { get; set; }
        [JsonProperty("coolDownBurn")]
        public string coolDownBurn { get; set; }
        [JsonProperty("effect")]
        public List<dynamic> effect { get; set; }
        [JsonProperty("effectBurn")]
        public string[] effectBurn { get; set; }
        [JsonProperty("vars")]
        public Vars[] vars { get; set; }
        [JsonProperty("range")]
        public int[] range { get; set; }
        [JsonProperty("rangeBurn")]
        public string rangeBurn { get; set; }
        [JsonProperty("key")]
        public string key { get; set; }
    }
}
