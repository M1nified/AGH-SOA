using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CosmicAdventureDTO;

namespace CosmosWcfServiceLibrary
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, Name = "Cosmos")]
    public class CosmosWcf : ICosmosWcf
    {
        List<SpaceSystem> _systems = new List<SpaceSystem>();

        public Starship GetStarship(int money)
        {
            Starship starship = new Starship();
            Random random = new Random();
            if (money > 1000 && money <= 3000)
                starship.ShipPower = random.Next(10, 25);
            else if (money <= 10000)
                starship.ShipPower = random.Next(20, 35);
            else if (money > 10000)
                starship.ShipPower = random.Next(35, 60);

            starship.Gold = 0;

            for (int i = 0; i < 4; i++)
            {
                starship.Crew.Add(new Person()
                {
                    Age = 20,
                    Name = "Mate"
                });
            }

            return starship;
        }

        public SpaceSystem GetSystem()
        {
            return _systems.First();
        }

        public void InitializeGame()
        {
            Random random = new Random();
            for(int i = 0; i < 4; i++)
            {
                _systems.Add(new SpaceSystem()
                {
                    BaseDistance = random.Next(20, 120),
                    MinShipPower = random.Next(10, 40),
                    Gold = random.Next(3000, 7000)
                });
            }
        }

        public Starship SendStarship(Starship starship, string systemName)
        {
            SpaceSystem system = _systems.Find(x => x.Name == systemName);
            if (system != null)
            {
                Action<Person> ageDifference;
                if (starship.ShipPower <= 20)
                    ageDifference = member => member.Age += 2 * system.BaseDistance / 12;
                else if (starship.ShipPower <= 30)
                    ageDifference = member => member.Age += 2 * system.BaseDistance / 6;
                else
                    ageDifference = member => member.Age += 2 * system.BaseDistance / 4;

                starship.Crew.ForEach(member => {
                    ageDifference(member);
                    if (member.Age > 90)
                        starship.Crew.Remove(member);
                });

                if(starship.ShipPower > system.MinShipPower)
                {
                    starship.Gold = system.Gold;
                    _systems.Remove(system);
                }

            }
            else
            {
                starship.Crew.Clear();
            }
            return starship;
        }
    }
}
