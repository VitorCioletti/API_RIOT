using Newtonsoft.Json;
using System.Collections.Generic;

namespace riotAPI_teste
{
    class Champion
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("key")]
        public string key { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("image")]
        public Image image { get; set; }
        [JsonProperty("skins")]
        public Skin[] skins { get; set; }
        [JsonProperty("allTips")]
        public string[] allTips { get; set; }
        [JsonProperty("enemyTips")]
        public string[] enemyTips { get; set; }
        [JsonProperty("tags")]
        public string[] tags { get; set; }
        [JsonProperty("partype")]
        public string partype { get; set; }
        [JsonProperty("info")]
        public Dictionary<string, int> info { get; set; }
        [JsonProperty("spells")]
        public Spell[] spells { get; set; }
        [JsonProperty("stats")]
        public Stat stats { get; set; }
        [JsonProperty("passive")]
        public Passive passive { get; set; }
        [JsonProperty("recommended")]
        public Recommended[] recommended { get; set; }
    }
}
