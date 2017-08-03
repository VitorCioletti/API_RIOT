using Newtonsoft.Json;

namespace riotAPI_teste
{
    public class LevelTip
    {
        [JsonProperty("label")]
        public string[] label { get; set; }
        [JsonProperty("effect")]
        public string[] effect { get; set; }
    }
}
