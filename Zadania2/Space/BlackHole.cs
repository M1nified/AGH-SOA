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
																Starship newShip = (Starship)ship.Clone();
                newShip.Crew.ForEach(delegate(Person mate)
                {
																				mate.Age += 20;
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
