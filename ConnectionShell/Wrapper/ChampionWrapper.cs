using System.Collections.Generic;
using Newtonsoft.Json;
namespace riotAPI_teste
{
    class ChampionWrapper
    {
        [JsonProperty("data")]
        public Dictionary<string, Champion> Data { get; set; }
        [JsonProperty("keys")]
        public Dictionary<int, string> Keys { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
