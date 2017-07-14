using System.Collections.Generic;
using Newtonsoft.Json;
namespace riotAPI_teste
{
    class ChampionWrapper
    {
        [JsonProperty("data")]
        public Dictionary<int, Champion> data;
        [JsonProperty("keys")]
        public Dictionary<int, string> keys;
        [JsonProperty("format")]
        public string format;
        [JsonProperty("type")]
        public string type;
        [JsonProperty("version")]
        public string version;
    }
}
