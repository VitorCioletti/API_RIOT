using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;


namespace riotAPI_teste
{
    class Server
    {
        private Summoner summoner = new Summoner();
        private static string apiSummonerName;
        private static string apiKey = "api_key=RGAPI-349b5f6c-d858-4a49-b85d-71ee7c713910";
        private static string apiPvpNet = ".api.riotgames.com/api/lol/";
        private string aUrl;
        
        public Server(string name, string region){
            this.summoner.name = name;
            this.summoner.region = region;
        }
        private StreamReader httpRequest(string url){
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            try{
                WebResponse response = request.GetResponse();
                StreamReader document = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8);
                return document;
            } catch (Exception) { Console.WriteLine("Sem conexão de internet"); return null;}
            //COMO FECHAR RESPONSE E REQUEST? (CLOSE)
        }
        private dynamic serializeJson(string json) {
            var serializer = new JavaScriptSerializer();
            dynamic result = serializer.DeserializeObject(json);
            return result;            
        }

        public void summonerSearch(string region) {
            apiSummonerName = "/v1.4/summoner/by-name/";
            if (region == "" || summoner.name == "") return;
            try{
                aUrl = "https://" + region.ToLower() + apiPvpNet + region.ToUpper() + apiSummonerName + summoner.name +"?"+apiKey;
                string json = httpRequest(aUrl).ReadToEnd();
                dynamic result = serializeJson(json);
                Console.WriteLine(result[summoner.name.ToLower()]["id"]);
                this.summoner.id = (Convert.ToString(result[summoner.name.ToLower()]["id"]));
                this.summoner.profileIconId = (Convert.ToString(result[summoner.name.ToLower()]["profileIconId"]));
                this.summoner.summonerLevel = (result[summoner.name.ToLower()]["summonerLevel"]);
                this.summoner.revisionDate = (result[summoner.name.ToLower()]["revisionDate"]);
                this.summoner.name = (Convert.ToString(result[summoner.name.ToLower()]["name"]));
                Console.WriteLine("Id: {0}  Profile Icon: {1}  Revision Date: {2} Name: {3} Level: {4}",summoner.id,summoner.profileIconId,summoner.revisionDate,summoner.name, summoner.summonerLevel);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public void recentMatches(){
            string rankedSeason = summoner.region;
            string matchStats = "https://br.api.riotgames.com/api/lol/";
            string detailStats = "/v1.3/game/by-summoner/";
            aUrl = matchStats + this.summoner.region + detailStats + this.summoner.id+"/recent?" + apiKey;
            string json = httpRequest(aUrl).ReadToEnd();
            Dictionary<string, dynamic> recentMatches = serializeJson(json);
            //CONTINUAR DAQUI
            Process.Start(aUrl);
        }
    }
}
