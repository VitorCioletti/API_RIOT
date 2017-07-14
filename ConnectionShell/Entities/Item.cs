using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Item
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("count")]
        public int count { get; set; }
    }
}
