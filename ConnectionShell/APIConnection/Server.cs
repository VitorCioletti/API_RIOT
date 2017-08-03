using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;
using System.Net;


namespace riotAPI_teste
{
    public class Server
    {
        private static Server server;

        private Server() { }

        public static Server GetInstance()
        {
            if (Server.server == null)
                return new Server();
            else 
                return server;            
        }
        
        public ChampionWrapper GetChampions()
        {
            RestClient client = new RestClient(new Uri(ConfigurationManager.AppSettings["apiUrl"], UriKind.RelativeOrAbsolute));
            RestRequest request = new RestRequest(Method.GET);
            request.AddParameter("api_key",ConfigurationManager.AppSettings["apiKey"]);
            var response = client.Execute(request);
            if(response.StatusCode == HttpStatusCode.OK){
                ChampionWrapper championsList = JsonConvert.DeserializeObject<ChampionWrapper>(response.Content);
                return championsList;
            } else {
                return null;
            }
        }
    }
}
