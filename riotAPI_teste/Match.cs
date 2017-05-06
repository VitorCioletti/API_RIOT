using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riotAPI_teste
{
    class Match
    {
        [JsonProperty("gameId")]
        public string gameId { get; set; }
        [JsonProperty("invalid")]
        public bool invalid { get; set; }
        [JsonProperty("gameMode")]
        public string gameMode { get; set; }
        [JsonProperty("gameType")]
        public string gameType { get; set; }
        [JsonProperty("subType")]
        public string subType { get; set; }
        [JsonProperty("mapId")]
        public int mapId { get  ; set; }
        [JsonProperty("teamId/")]
        public int teamId { get; set; }
        [JsonProperty("championId")]
        public int championId { get; set; }
        [JsonProperty("spell1")]
        public int spell1 { get; set; }
        [JsonProperty("spell4")]
        public int spell4 { get; set; }
        [JsonProperty("level")]
        public int level { get; set; }
        [JsonProperty("ipEarned")]
        public int ipEarned { get; set; }
        [JsonProperty("createDate")]
        public long createDate { get; set; }
        [JsonProperty("fellowPlayers")]
        public fellowPlayers[] fellowPlayers = new fellowPlayers[10];
        [JsonProperty("stats")]
        public Stats stats = new Stats();
        public Match() { }
    }
    class Stats
    {
        [JsonProperty("level")]
        public int level { get; set; }
        [JsonProperty("goldEarned")]
        public int goldEarned { get; set; }
        [JsonProperty("numDeaths")]
        public int numDeaths { get; set; }
        [JsonProperty("minionsKilled")]
        public int minionsKilled { get; set; }
        [JsonProperty("championsKilled")]
        public int championsKilled { get; set; }
        [JsonProperty("goldSpent")]
        public int goldSpent { get; set; }
        [JsonProperty("totalDamageDealt")]
        public int totalDamageDealt { get; set; }
        [JsonProperty("totalDamageTaken")]
        public int totalDamageTaken { get; set; }
        [JsonProperty("team")]
        public int team { get; set; }
        [JsonProperty("win")]
        public bool win { get; set; }
        [JsonProperty("largestMultiKill")]
        public int largestMultiKill { get; set; }
        [JsonProperty("physicalDamageDealtPlayer")]
        public int physicalDamageDealtPlayer { get; set; }
        [JsonProperty("magicDamageDealtPlayer")]
        public int magicDamageDealtPlayer { get; set; } //
        [JsonProperty("physicalDamageTaken")]
        public int physicalDamageTaken { get; set; }
        [JsonProperty("magicDamageTaken")]
        public int magicDamageTaken { get; set; }
        [JsonProperty("timePlayed")]
        public int timePlayed { get; set; }
        [JsonProperty("totalHeal")]
        public int totalHeal { get; set; }
        [JsonProperty("totalUnitsHealed")]
        public int totalUnitsHealed { get; set; }
        [JsonProperty("assists")]
        public int assists { get; set; }
        [JsonProperty("item0")]
        public int item0 { get; set; }
        [JsonProperty("item1")]
        public int item1 { get; set; }
        [JsonProperty("item2")]
        public int item2 { get; set; }
        [JsonProperty("item3")]
        public int item3 { get; set; }
        [JsonProperty("item4")]
        public int item4 { get; set; }
        [JsonProperty("item5")]
        public int item5 { get; set; }
        [JsonProperty("item6")]
        public int item6 { get; set; }
        [JsonProperty("magicDamageDealtToChampions")]
        public int magicDamageDealtToChampions { get; set; }
        [JsonProperty("physicalDamageDealtToChampions")]
        public int physicalDamageDealtToChampions { get; set; }
        [JsonProperty("totalDamageDealtToChampions")]
        public int totalDamageDealtToChampions { get; set; }
        [JsonProperty("trueDamageDealtPlayer")]
        public int trueDamageDealtPlayer { get; set; }
        [JsonProperty("trueDamageDealtToChampions")]
        public int trueDamageDealtToChampions { get; set; }
        [JsonProperty("trueDamageTaken")]
        public int trueDamageTaken { get; set; }
        [JsonProperty("wardKilled")]
        public int wardKilled { get; set; }
        [JsonProperty("wardPlaced")]
        public int wardPlaced { get; set; }
        [JsonProperty("totalTimeCrowdControlDealt")]
        public int totalTimeCrowdControlDealt { get; set; }
        [JsonProperty("playerRole")]
        public int playerRole { get; set; }
        [JsonProperty("playerPosition")]
        public int playerPosition { get; set; }
        [JsonProperty("totalDamageDealtToBuildings")]
        public int totalDamageDealtToBuildings { get; set; }
        [JsonProperty("visionWardsBought")]
        public int visionWardsBought { get; set; }
    }
    class fellowPlayers{
        [JsonProperty("summonerId")]
        public int summonerId { get; set; }
        [JsonProperty("championId")]
        public int championId { get; set; }
        [JsonProperty("teamId")]
        public int teamId { get; set; }
    }
}
