using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Summoner
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("accountId")]
        public string accountId { get; set; }
        [JsonProperty("profileIconId")]
        public string profileIconId { get; set; }
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("revisionDate")]
        public long revisionDate { get; set; }
        [JsonProperty("SummonerLevel")]
        public int summonerLevel  { get; set; }
        [JsonProperty("region")]
        public string region { get; set; }
    }

}
