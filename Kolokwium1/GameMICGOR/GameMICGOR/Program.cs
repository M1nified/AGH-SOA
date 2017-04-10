using GameMICGOR.CaveService1;
using GameMICGOR.DragonCaveService1;
using GameMICGOR.HobbitsWCFService1;
using GameMICGOR.PalantirWCFService1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMICGOR
{
    class Program
    {
        private static Dictionary<ConsoleKey, Command> commands = new Dictionary<ConsoleKey, Command>();
        private static CaveClient cave = new CaveClient();
        private static HobbitsClient hobbits = new HobbitsClient();
        private static DragonCaveClient dragonCave = new DragonCaveClient();
        private static PalantirWCFClient palantir = new PalantirWCFClient();
        private static string playerCode;
        private static int playerId;
        private static string playerName;
        private static Location currentLocation;
        static void Main(string[] args)
        {
            PopulateCommands();
            playerName = Console.ReadLine();
            playerCode = Console.ReadLine();
            playerId = hobbits.CreatePlayer(playerName, playerCode);
            currentLocation = cave.Init(playerName);
            while (true)
            {
                DisplayMenu();
                ProcessSituation();
            }
        }
        static void DisplayMenu()
        {
            foreach (var command in commands)
            {
                Console.WriteLine("{0}\t{1}", command.Value.Key, command.Value.Description);
            }
            var key = Console.ReadKey();
            if (commands.ContainsKey(key.Key))
            {
                var command = commands[key.Key];
                command.Action();
            }
            else
            {
                Console.WriteLine("Bledna komenda");
                DisplayMenu();
            }
        }
        static void PopulateCommands()
        {
            // Moves --------------------
            commands.Add(ConsoleKey.N, new Command()
            {
                Key = ConsoleKey.N,
                Description = "Idz w gore",
                Action = () =>
                {
                    currentLocation = cave.Move(0, playerName);
                }
            });
            commands.Add(ConsoleKey.E, new Command()
            {
                Key = ConsoleKey.E,
                Description = "Idz w prawo",
                Action = () =>
                {
                    currentLocation = cave.Move(1, playerName);
                }
            });
            commands.Add(ConsoleKey.S, new Command()
            {
                Key = ConsoleKey.S,
                Description = "Idz w dol",
                Action = () =>
                {
                    currentLocation = cave.Move(2, playerName);
                }
            });
            commands.Add(ConsoleKey.W, new Command()
            {
                Key = ConsoleKey.W,
                Description = "Idz w lewo",
                Action = () =>
                {
                    currentLocation = cave.Move(3, playerName);
                }
            });
            // ------------------------------
        }
        static void ProcessSituation()
        {
            if (currentLocation.Center == "zloto")
            {

            }
            else if (currentLocation.Center == "klucz")
            {

            }
        }
    }
}
