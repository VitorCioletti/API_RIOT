using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Block
    {
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("recMath")]
        public bool recMath { get; set; }
        [JsonProperty("items")]
        public Item[] items { get; set; }
    }
}
