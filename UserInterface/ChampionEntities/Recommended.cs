using Newtonsoft.Json;
using System.Collections.Generic;

namespace riotAPI_teste
{
    public class Recommended
    {
        public string champion { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public List<Block> blocks { get; set; }
    }
}
