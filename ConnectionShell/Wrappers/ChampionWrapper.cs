using System.Collections.Generic;
using Newtonsoft.Json;
namespace riotAPI_teste
{
    class ChampionWrapper
    {
        [JsonProperty("data")]
        public Dictionary<string, Champion> data { get; set; }
        [JsonProperty("keys")]
        public Dictionary<int, string> keys { get; set; }
        [JsonProperty("format")]
        public string format { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("version")]
        public string version { get; set; }
    }
}
