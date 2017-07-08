using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste.Entities
{
    class Vars
    {
        [JsonProperty("key")]
        public string key;
        [JsonProperty("link")]
        public string link;
        [JsonProperty("coeff")]
        public double[] coeff;

    }
}
