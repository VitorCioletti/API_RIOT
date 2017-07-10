using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace riotAPI_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Summoner summoner = new Summoner();
            Console.WriteLine("\t\tLeague of Legends - API");
            Console.Write("\nNome do invocador: ");
            summoner.name = Console.ReadLine();
            Console.Write("\nRegião: ");
            summoner.region = Console.ReadLine();
            Server server = Server.GetInstance(summoner.name, summoner.region);
            Console.WriteLine("\n\nSummoner ID: " + server.summonerSearch(summoner.region).id+"\n");
            MatchWrapper recentMatches = server.recentMatches();
            for (int i = 0; i < recentMatches.games.Length; i++){
                Console.WriteLine("Game Id: "+ recentMatches.games[i].gameId + " Vitoria: " + recentMatches.games[i].stats.win + " Champion: "+ recentMatches.games[i].championId);
            }
            
            server.recentMatches();
            server.getChampions();
            Console.ReadKey();
        }
    }
}
