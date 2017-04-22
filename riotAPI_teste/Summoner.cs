using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riotAPI_teste
{
    class Summoner
    {
        public string name { get; set; }
        public string accountId { get; set; }
        public string profileIconId { get; set; }
        public string id { get; set; }
        public long revisionDate { get; set; }
        public int summonerLevel  { get; set; }
        public string region { get; set; }
        public List<Match> rankedMatches = new List<Match>();
    }

}
