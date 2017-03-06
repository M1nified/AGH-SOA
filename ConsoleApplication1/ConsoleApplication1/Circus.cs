using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Circus : ICircus
    {
        public List<Animal> Animals = new List<Animal>();
        public string Name = "This circus has no name";

        public string AnimalsIntroduction()
        {
            string sounds = "";
            Animals.ForEach(delegate(Animal animal)
            {
                sounds += animal.Sound();
            });
            return sounds;
        }
        public string Show()
        {
            string tricks = "";
            Animals.ForEach(delegate(Animal animal)
            {
                tricks += animal.Trick();
            });
            return tricks;
        }
        public int Patter(int howMuch)
        {
            int count = 0;
            Animals.ForEach(delegate(Animal animal)
            {
                count += animal.CountLegs();
            });
            return count * howMuch;
        }
    }
}
