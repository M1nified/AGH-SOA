using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Zoo zoo1 = new Zoo();
            zoo1.Name = "Zoo 1";
            Elephant elephant1 = new Elephant();
            elephant1.Name = "Slon 1";
            Ant ant1 = new Ant();
            Pony pony1 = new Pony();
            zoo1.Animals.Add(elephant1);
            zoo1.Animals.Add(ant1);
            zoo1.Animals.Add(pony1);

            Console.WriteLine("a) Prezentacja zwierzat w cyrku");
            Console.WriteLine("b) Program");
            Console.WriteLine("c) Dzwieki");
            Console.WriteLine("d) Imie pierwszego");
            Console.WriteLine("e) Wszystkie imiona");

            ConsoleKeyInfo key = Console.ReadKey();

            Circus circus1 = new Circus();
            switch (key.Key)
            {
                case ConsoleKey.A:
                    Console.Write(circus1.AnimalsIntroduction());
            }

        }
    }
}
