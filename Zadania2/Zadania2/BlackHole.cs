using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    public class BlackHole : IBlackHole
    {
        public Starship PullStarship(Starship ship)
        {
            if (ship.Captain.Age <= 40)
            {
                Starship newShip = new Starship();
                ship.Crew.ForEach(delegate(Person mate)
                {
                    Person newMate = new Person();
                    newMate.Age = newMate.Age + 20;
                    newShip.Crew.Add(newMate);
                });
                return newShip;
            }
            return ship;
        }
        public string UltimateAnswer()
        {
            return 42.ToString();
        }
    }
}
