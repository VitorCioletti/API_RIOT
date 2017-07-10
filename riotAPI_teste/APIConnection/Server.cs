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
        private static Summoner summoner = new Summoner();
        private static string apiSummonerName;
        private static RiotKey key = new RiotKey();
        private static string apiPvpNet = ".api.riotgames.com/api/lol/";
        private string aUrl;
        private static Server server;
        
        public Server(string name, string region){
            
        }
        private Server() { }

        public static Server GetInstance(string name, string region) {
            if (Server.summoner != null){
                Server.summoner.name = name;
                Server.summoner.region = region;
                Server.server = new Server();
                return server;
            }
            else {
                return Server.server;
            }
        }
        /// <summary>
        /// Requests data from RIOT API
        /// </summary>
        /// <param name="url"> API url</param>
        /// <returns>StreamReader object with json string</returns>
        public StreamReader httpRequest(string url){
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            try{
                WebResponse response = request.GetResponse();
                StreamReader document = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8);
                return document;
            } catch (Exception ex) {Console.WriteLine(ex.Message); return null;}
        }
        /// <summary>
        /// Deserialize json
        /// </summary>
        /// <param name="json">JSON to be deserialized</param>
        /// <returns>Dynamic type of json deserialized</returns>
        private dynamic deserializeJson(string json) {
            var serializer = new JavaScriptSerializer();
            var result = serializer.DeserializeObject(json);
            return result;            
        }
        /// <summary>
        /// Requests information of a certain summoner from server.
        /// </summary>
        /// <param name="region">Region of the sumonner</param>
        /// <returns>Summoner type</returns>
        public Summoner summonerSearch(string region) {
            apiSummonerName = "/v1.4/summoner/by-name/";
            if (region == "" || summoner.name == "") return null;
            try{
                aUrl = "https://" + region.ToLower() + apiPvpNet + region.ToUpper() + apiSummonerName + Server.summoner.name +"?"+Server.key.apiKey;
                string json = httpRequest(aUrl).ReadToEnd();
                var result = deserializeJson(json);
                Console.WriteLine(result.message);
                Server.summoner = JsonConvert.DeserializeObject<SummonerWrapper>(json).summoner;
                Server.summoner.region = region;
                return Server.summoner;
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
        public MatchWrapper recentMatches(){         
            string rankedSeason = summoner.region;
            string matchStats = "https://br.api.riotgames.com/api/lol/";
            string detailStats = "/v1.3/game/by-summoner/";
            aUrl = matchStats + Server.summoner.region + detailStats + Server.summoner.id+"/recent?" + Server.key.apiKey;
            string json = httpRequest(aUrl).ReadToEnd();
            MatchWrapper recentMatches = JsonConvert.DeserializeObject<MatchWrapper>(json);
            return recentMatches;
        }
        public dynamic getChampions() {
            string value = "https://br1.api.riotgames.com/lol/static-data/v3/champions?champListData=all&dataById=true&";
            aUrl = value + Server.key.apiKey;
            string json = httpRequest(aUrl).ReadToEnd();
            ChampionWrapper champions = JsonConvert.DeserializeObject<ChampionWrapper>(json);
            string listChampions = httpRequest(aUrl).ReadToEnd();
            return listChampions;
        } 
    }
}
