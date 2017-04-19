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
        public static string apiSummonerName;
        public static string apiKey = "api_key=RGAPI-349b5f6c-d858-4a49-b85d-71ee7c713910";
        public static string apiPvpNet = ".api.riotgames.com/api/lol/";
        public static string aUrl;
        
        public Server(string name, string region){
            this.summoner.name = name;
            this.summoner.region = region;
        }

        public void summonerSearch(string region) {
            apiSummonerName = "/v1.4/summoner/by-name/";
            if (region == "" || summoner.name == "") return;
            try{
                aUrl = "https://" + region.ToLower() + apiPvpNet + region.ToUpper() + apiSummonerName + summoner.name +"?"+apiKey;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(aUrl);
                request.Method = "GET";
                WebResponse response = request.GetResponse();
                StreamReader document = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8);
                string json = document.ReadToEnd();
                var serializer = new JavaScriptSerializer();
                dynamic result = serializer.DeserializeObject(json);
                Console.WriteLine(result[summoner.name.ToLower()]["id"]);
                this.summoner.id = (Convert.ToString(result[summoner.name.ToLower()]["id"]));
                this.summoner.profileIconId = (Convert.ToString(result[summoner.name.ToLower()]["profileIconId"]));
                this.summoner.summonerLevel = (result[summoner.name.ToLower()]["summonerLevel"]);
                this.summoner.revisionDate = (result[summoner.name.ToLower()]["revisionDate"]);
                this.summoner.name = (Convert.ToString(result[summoner.name.ToLower()]["name"]));
                Console.WriteLine("Id: {0}  Profile Icon: {1}  Revision Date: {2} Name: {3} Level: {4}",summoner.id,summoner.profileIconId,summoner.revisionDate,summoner.name, summoner.summonerLevel);
                document.Close();
                response.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public void rankedStats(){
            string rankedSeason = summoner.region;
            string rankedStats = "/v1.3/stats/by-summoner/";
            string seasonStats = "/ranked?season=SEASON2017";   //Season travada na 2017
            aUrl = "https://" +summoner.region.ToLower() + apiPvpNet + this.summoner.region.ToUpper() + rankedStats + this.summoner.id + seasonStats +"&"+ apiKey;
        }
    }
}
