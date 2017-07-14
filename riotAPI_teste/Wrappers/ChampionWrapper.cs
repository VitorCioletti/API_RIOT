using System.Collections.Generic;
using Newtonsoft.Json;
namespace riotAPI_teste
{
    class ChampionWrapper
    {
        [JsonProperty("")]
        public Dictionary<int, Champion> data;
        [JsonProperty("")]
        public Dictionary<int, string> keys;
        [JsonProperty("")]
        public string format;
        [JsonProperty("")]
        public string type;
        [JsonProperty("")]
        public string version;
    }
}
