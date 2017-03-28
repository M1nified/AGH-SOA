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
        private static CosmosWcfClient cosmos = new CosmosWcfClient();

        static void Main(string[] args)
        {
            cosmos.InitializeGame();

            PopulateCommands();

            DisplayMenu();

            Console.ReadKey();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Gold:\t{0}", _gold);
            Console.WriteLine("Imperium money ask count:\t{0}", _imperiumMoneyAskCount);
            foreach(var command in commands)
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
                    DisplayMenu();
                }
            });
            commands.Add(ConsoleKey.B, new Command()
            {
                Key = ConsoleKey.B,
                Description = "Kup statek za zloto",
                Action = () =>
                {
                    Console.WriteLine("Aktualne zloto: {0} Wpisz za ile z;pta chcesz kupic statek", _gold);
                    string amountString = Console.ReadLine();
                    int amount;
                    if(int.TryParse(amountString, out amount) && amount <= _gold)
                    {
                        _gold -= amount;
                        var newShip = cosmos.GetStarship(amount);
                        _starships.Add(newShip);
                    }
                    else
                    {
                        Console.WriteLine("Bledna kwota transakcji");
                    }
                    DisplayMenu();
                }
            });
            commands.Add(ConsoleKey.C, new Command()
            {
                Key = ConsoleKey.C,
                Description = "Wyslij statek do systemu",
                Action = () =>
                {
                    var system = cosmos.GetSystem();
                    if (system == null)
                    {
                        _anySystem = false;
                        Console.WriteLine("Brak systemow");
                    }
                    else
                    {
                        Console.WriteLine("System {0}, odleglosc {1}", system.Name, system.BaseDistance);
                        if(_starships.Count > 0)
                        {
                            Console.WriteLine("Statkow gotowych do podrozy: {0}", _starships.Count);
                            Console.WriteLine("Wybierz statek wpisujac jego numer (albo wyjdz wpisujac litere e):");
                            int count = 1;
                            _starships.ForEach(ship =>
                            {
                                Console.Write("{0}, {1}", count++,  ship.ShipPower);
                                ship.Crew.ToList().ForEach(person =>
                                {
                                    Console.Write(", {0} {1} {2}", person.Name, person.Nick, person.Age);
                                });
                                Console.WriteLine();
                            });
                            string input = Console.ReadLine();
                            int shipNumber;
                            if (int.TryParse(input, out shipNumber) && shipNumber <= _starships.Count && shipNumber > 0)
                            {
                                var theShip = _starships.ElementAt(shipNumber - 1);
                                _starships.RemoveAt(shipNumber - 1);
                                var newShip = cosmos.SendStarship(theShip, system.Name);
                                if(newShip.Gold > 0)
                                {
                                    _gold += newShip.Gold;
                                    newShip.Gold = 0;
                                }
                                if (newShip.Crew.Length > 0)
                                {
                                    _starships.Add(newShip);
                                }
                            }
                        }
                    }
                    DisplayMenu();
                }
            });
            commands.Add(ConsoleKey.D, new Command()
            {
                Key = ConsoleKey.D,
                Description = "Zakoncz gre",
                Action = () =>
                {
                    Console.WriteLine(_anySystem ? "Przegrana" : "Wygrana");
                }
            });
        }
    }
}
