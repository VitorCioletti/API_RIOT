using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Vars
    {
        [JsonProperty("key")]
        public string key { get; set; }
        [JsonProperty("link")]
        public string link { get; set; }
        [JsonProperty("coeff")]
        public double[] coeff { get; set; }

    }
}
