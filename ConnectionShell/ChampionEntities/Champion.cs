using Newtonsoft.Json;
using System.Collections.Generic;

namespace riotAPI_teste
{
   public  class Champion
    {
        public int id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public Image image { get; set; }
        public List<Skin> skins { get; set; }
        public List<string> allTips { get; set; }
        public List<string> enemyTips { get; set; }
        public List<string> tags { get; set; }
        public string partype { get; set; }
        public Dictionary<string, int> info { get; set; }
        public List<Spell> spells { get; set; }
        public Stat stats { get; set; }
        public Passive passive { get; set; }
        public List<Recommended> recommended { get; set; }
    }
}
