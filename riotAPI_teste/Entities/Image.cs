using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riotAPI_teste.Entities
{
    class Image
    {
        [JsonProperty("full")]
        public string full;
        [JsonProperty("sprite")]
        public string sprite;
        [JsonProperty("group")]
        public string group;
        [JsonProperty("x")]
        public int x;
        [JsonProperty("y")]
        public int y;
        [JsonProperty("w")]
        public int w;
        [JsonProperty("h")]
        public int h;
    }
}
