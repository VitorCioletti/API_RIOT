using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste
{
    class Image
    {
        [JsonProperty("full")]
        public string full { get; set; }
        [JsonProperty("sprite")]
        public string sprite { get; set; }
        [JsonProperty("group")]
        public string group { get; set; }
        [JsonProperty("x")]
        public int x { get; set; }
        [JsonProperty("y")]
        public int y { get; set; }
        [JsonProperty("w")]
        public int w { get; set; }
        [JsonProperty("h")]
        public int h { get; set; }
    }
}
