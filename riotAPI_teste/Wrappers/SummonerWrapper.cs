using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste
{
    class SummonerWrapper
    {
        [JsonProperty("afnar")]
        public Summoner summoner { get; set; }
    }
}
