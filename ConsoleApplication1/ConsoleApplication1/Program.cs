using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");

												Elephant elephant1 = new Elephant();
            elephant1.Name = "EloPhant";

            Ant ant1 = new Ant();
												ant1.Name = "AntMan";

            Pony pony1 = new Pony();
												pony1.Name = "My little pony";

												Zoo zoo1 = new Zoo();
												zoo1.Name = "Zoo 1";

												zoo1.Animals.Add(elephant1);
            zoo1.Animals.Add(ant1);
            zoo1.Animals.Add(pony1);

            Circus circus1 = new Circus();

            Console.WriteLine("a) Prezentacja Zwierząt w cyrku "+circus1.Name);
            Console.WriteLine("b) Obejrzenie programu cyrku "+circus1.Name);
            Console.WriteLine("c) Posłuchanie dźwięków Zoo "+zoo1.Name);
            Console.WriteLine("d) Wyświetla imię pierwszego znalezionego futrzaka w Zoo");
            Console.WriteLine("e) Wyświetla wszystkie imiona zwierząt w Cyrku ");

            ConsoleKeyInfo key = Console.ReadKey();
												Console.WriteLine();

            switch (key.Key)
            {
                case ConsoleKey.A:
                    Console.WriteLine(circus1.AnimalsIntroduction());
																				break;
																case ConsoleKey.B:
																				Console.WriteLine(circus1.Show());
																				break;
																case ConsoleKey.C:
																				Console.WriteLine(zoo1.Sounds());
																				break;
																case ConsoleKey.D:
																				Console.WriteLine(zoo1.Animals.First().Name);
																				break;
																case ConsoleKey.E:
																				zoo1.Animals.ForEach(delegate (Animal animal)
																				{
																								Console.WriteLine(animal.Name);
																				});
																				break;
            }

        }
    }
}
