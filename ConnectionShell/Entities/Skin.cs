using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Skin
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("num")]
        public int num { get; set; }

    }
}
