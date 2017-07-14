using Newtonsoft.Json;

namespace riotAPI_teste
{
    class SummonerWrapper : Summoner
    {
        [JsonProperty("afnar")]
        public Summoner summoner { get; set; }
    }
}
