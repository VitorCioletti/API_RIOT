﻿using System;
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
            } catch (Exception ex) {Console.WriteLine(ex.StackTrace); return null;}
            //HOW DO I CLOSE REQUEST AND RESPONSE? '-'
        }
        private dynamic deserializeJson(string json) {
            var serializer = new JavaScriptSerializer();
            dynamic result = serializer.DeserializeObject(json);
            return result;            
        }

        public Summoner summonerSearch(string region) {
            apiSummonerName = "/v1.4/summoner/by-name/";
            if (region == "" || summoner.name == "") return null;
            try{
                aUrl = "https://" + region.ToLower() + apiPvpNet + region.ToUpper() + apiSummonerName + this.summoner.name +"?"+apiKey;
                string json = httpRequest(aUrl).ReadToEnd();
                dynamic result = deserializeJson(json);
                this.summoner = JsonConvert.DeserializeObject<Wrapper>(json).summoner;
                this.summoner.region = region;
                return this.summoner;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }
        public dynamic recentMatches(){
            string rankedSeason = summoner.region;
            string matchStats = "https://br.api.riotgames.com/api/lol/";
            string detailStats = "/v1.3/game/by-summoner/";
            aUrl = matchStats + this.summoner.region + detailStats + this.summoner.id+"/recent?" + apiKey;
            string json = httpRequest(aUrl).ReadToEnd();
            var recentMatches = JsonConvert.DeserializeObject<MatchWrapper>(json);
            return recentMatches;
        }
    }
}
