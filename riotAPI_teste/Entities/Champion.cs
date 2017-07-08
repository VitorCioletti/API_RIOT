using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste.Entities
{
    class Champion
    {
        [JsonProperty("id")]
        public int id;
        [JsonProperty("key")]
        public string key;
        [JsonProperty("name")]
        public string name;
        [JsonProperty("title")]
        public string title;
        [JsonProperty("image")]
        public Image image;
        [JsonProperty("skins")]
        public Skin[] skins;
        [JsonProperty("allTips")]
        public string[] allTips;
        [JsonProperty("enemyTips")]
        public string[] enemyTips;
        [JsonProperty("tags")]
        public string[] tags;
        [JsonProperty("partype")]
        public string partype;
        [JsonProperty("info")]
        public Info[] info;
        [JsonProperty("spells")]
        public Spell[] spells;
        [JsonProperty("stats")]
        public Stats stats;
        [JsonProperty("passive")]
        public Passive passive;
        [JsonProperty("recommended")]
        public Recommended[] recommended;
    }
}
