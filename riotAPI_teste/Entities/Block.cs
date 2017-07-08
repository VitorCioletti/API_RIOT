using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste.Entities
{
    class Block
    {
        [JsonProperty("type")]
        public string type;
        [JsonProperty("recMath")]
        public bool recMath;
        [JsonProperty("items")]
        public Item[] items;
    }
}
