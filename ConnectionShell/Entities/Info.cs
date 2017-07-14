using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Info
    {
        [JsonProperty("attack")]
        public int attack { get; set; }
        [JsonProperty("defense")]
        public int defense { get; set; }
        [JsonProperty("magic")]
        public int magic { get; set; }
        [JsonProperty("difficulty")]
        public int difficulty { get; set; }
    }
}
