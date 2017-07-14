using System;

namespace riotAPI_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Summoner summoner = new Summoner();
            Console.WriteLine("\t\tLeague of Legends");
            summoner.name = "AFNAR";
            summoner.region = "BR";
            Server server = Server.GetInstance();
            summoner = server.summonerSearch(summoner);
            Console.WriteLine("\n\nSummoner ID: " + summoner.id + "\n");
            MatchWrapper recentMatches = server.recentMatches(summoner);
            for (int i = 0; i < recentMatches.games.Length; i++)
            {
                Console.WriteLine("Game Id: " + recentMatches.games[i].gameId + " Vitoria: " + recentMatches.games[i].stats.win + " Champion: " + recentMatches.games[i].championId);
            }

            server.getChampions();
            Console.ReadKey();
        }
    }
}
