using Newtonsoft.Json;

namespace riotAPI_teste
{
    class LevelTip
    {
        [JsonProperty("label")]
        public string[] label { get; set; }
        [JsonProperty("effect")]
        public string[] effect { get; set; }
    }
}
