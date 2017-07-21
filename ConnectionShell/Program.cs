using System;

namespace riotAPI_teste
{
    class Program
    {
        static void Main(string[] args)
        {

            Server server = Server.GetInstance();
            ChampionWrapper clist = server.GetChampions();
            Console.ReadKey();
        }
    }
}
