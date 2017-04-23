using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riotAPI_teste
{
    class Wrapper
    {
        [JsonProperty("afnar")]  //COMO ALTERAR ESSA PROPRIEDADE DE ACORDO COM A ENTRADA DO USER?
        public Summoner summoner { get; set; }
    }
    class MatchWrapper 
    {
        [JsonProperty("summonerId")]
        public int summonerId { get; set; }
        [JsonProperty("games")]
        public Match[] games = new Match[10]; //Api sempre retorna ultimas 10 partidas.
    }

}
