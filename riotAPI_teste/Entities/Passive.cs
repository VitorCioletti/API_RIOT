using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Passive
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("sanitizedDescription")]
        public string sanitizedDescription { get; set; }
        [JsonProperty("image")]
        public Image image { get; set; }

    }
}
