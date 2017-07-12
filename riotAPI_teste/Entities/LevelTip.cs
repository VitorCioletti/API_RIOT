using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste
{
    class LevelTip
    {
        [JsonProperty("label")]
        public string[] label { get; set; }
        [JsonProperty("effect")]
        public string[] effect { get; set; }
    }
}
