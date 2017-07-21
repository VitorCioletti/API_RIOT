using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Vars
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("coeff")]
        public double[] Coeff { get; set; }

    }
}
