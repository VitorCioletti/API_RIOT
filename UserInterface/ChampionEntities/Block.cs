using Newtonsoft.Json;
using System.Collections.Generic;

namespace riotAPI_teste
{
  public  class Block
    {
        public string type { get; set; }

        public bool recMath { get; set; }

        public List<Item> items { get; set; }
    }
}
