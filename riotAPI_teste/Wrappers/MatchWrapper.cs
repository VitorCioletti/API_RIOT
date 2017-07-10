using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
