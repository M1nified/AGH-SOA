using CosmosGameApp.Cosmos;
using CosmosGameApp.FirstOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosGameApp
{
    class Program
    {
        private static List<Starship> _starships = new List<Starship>();
        private static bool _anySystem = true;
        private static int _gold = 1000;
        private static int _imperiumMoneyAskCount = 4;
        private static Dictionary<ConsoleKey, Command> commands = new Dictionary<ConsoleKey, Command>();

        static void Main(string[] args)
        {
            CosmosWcfClient cosmos = new CosmosWcfClient();
            cosmos.InitializeGame();

            commands.Add(ConsoleKey.A, new Command()
            {
                Key = ConsoleKey.A,
                Description = "Popros imperium o zloto",
                Action = () =>
                {
                    if (_imperiumMoneyAskCount > 0)
                    {
                        FirstOrderClient fo = new FirstOrderClient();
                        _gold += fo.GetMoneyFromImperium();
                        _imperiumMoneyAskCount--;
                    }
                }
            });

            Console.ReadKey();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Gold:\t%d", _gold);
            Console.WriteLine("Imperium money ask count:\t%d", _imperiumMoneyAskCount);
        }
    }
}
