using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste.Entities
{
    class Info
    {
        [JsonProperty("attack")]
        public int attack;
        [JsonProperty("defense")]
        public int defense;
        [JsonProperty("magic")]
        public int magic;
        [JsonProperty("difficulty")]
        public int difficulty;
    }
}
