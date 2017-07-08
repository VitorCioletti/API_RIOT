using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste.Entities
{
    class Passive
    {
        [JsonProperty("name")]
        public string name;
        [JsonProperty("description")]
        public string description;
        [JsonProperty("sanitizedDescription")]
        public string sanitizedDescription;
        [JsonProperty("image")]
        public Image image;

    }
}
