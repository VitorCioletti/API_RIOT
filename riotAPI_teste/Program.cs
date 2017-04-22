using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Server server = new Server(summoner.name, summoner.region);
            server.summonerSearch(summoner.region);
            server.recentMatches();
            Console.ReadKey();
        }
    }
}
