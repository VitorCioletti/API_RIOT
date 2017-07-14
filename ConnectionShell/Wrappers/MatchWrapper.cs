using Newtonsoft.Json;

namespace riotAPI_teste
{
    class MatchWrapper
        {
            [JsonProperty("summonerId")]
            public int summonerId { get; set; }
            [JsonProperty("games")]
            public Match[] games = new Match[10];
        }
}
