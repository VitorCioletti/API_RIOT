using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Recommended
    {
        [JsonProperty("champion")]
        public string champion { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("map")]
        public string map { get; set; }
        [JsonProperty("mode")]
        public string mode { get; set; }
        [JsonProperty("blocks")]
        public Block[] blocks { get; set; }
    }
}
