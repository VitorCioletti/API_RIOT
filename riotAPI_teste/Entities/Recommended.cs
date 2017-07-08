using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;  
namespace riotAPI_teste.Entities
{
    class Recommended
    {
        [JsonProperty("champion")]
        public string champion;
        [JsonProperty("title")]
        public string title;
        [JsonProperty("type")]
        public string type;
        [JsonProperty("map")]
        public string map;
        [JsonProperty("mode")]
        public string mode;
        [JsonProperty("blocks")]
        public Block[] blocks;
    }
}
