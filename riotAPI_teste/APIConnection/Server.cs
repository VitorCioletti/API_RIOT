using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;


namespace riotAPI_teste
{
    class Server
    {
        private static HttpRequest httpRequest;
        private static RiotKey key = new RiotKey();
        private static string apiPvpNet = ".api.riotgames.com/api/lol/";
        private string aUrl;
        private static Server server;
        
        private Server() { }

        public static Server GetInstance()
        {
            if (Server.server == null){
                httpRequest = new HttpRequest();
                server = new Server();
                return server;
            } else {
                return server;
            }
        }
        /// <summary>
        /// Requests information of a certain summoner from server.
        /// </summary>
        /// <param name="region">Region of the sumonner</param>
        /// <returns>Summoner type</returns>
        public Summoner summonerSearch(Summoner summoner)
        {
            string apiSummonerName = "/v1.4/summoner/by-name/";
            if (summoner.region == "" || summoner.name == "")
                return null;
            try{
                aUrl = "https://" + summoner.region.ToLower() + apiPvpNet + summoner.region.ToUpper() + apiSummonerName + summoner.name +"?"+Server.key.apiKey;
                string json = Server.httpRequest.getJson(aUrl).ReadToEnd();
                Summoner response = JsonConvert.DeserializeObject<SummonerWrapper>(json).summoner;
                response.region = summoner.region;
                return response;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }
        /// <summary>
        /// Gets 10 recent matches from a certain user that is already created in the program
        /// </summary>
        /// <returns>List of recent matches</returns>
        public MatchWrapper recentMatches(Summoner summoner)
        {
            if (summoner.id != null) {
                string rankedSeason = summoner.region;
                string matchStats = "https://br.api.riotgames.com/api/lol/";
                string detailStats = "/v1.3/game/by-summoner/";
                aUrl = matchStats + summoner.region + detailStats + summoner.id + "/recent?" + Server.key.apiKey;
                string json = Server.httpRequest.getJson(aUrl).ReadToEnd();
                MatchWrapper recentMatches = JsonConvert.DeserializeObject<MatchWrapper>(json);
                return recentMatches;
            } else
                return null;
        }
        public ChampionWrapper getChampions()
        {
            string value = "https://br1.api.riotgames.com/lol/static-data/v3/champions?champListData=all&dataById=true&";
            aUrl = value + Server.key.apiKey;
            string json = Server.httpRequest.getJson(aUrl).ReadToEnd();
            ChampionWrapper champions = JsonConvert.DeserializeObject<ChampionWrapper>(json);
            return champions;
        } 
    }
}
