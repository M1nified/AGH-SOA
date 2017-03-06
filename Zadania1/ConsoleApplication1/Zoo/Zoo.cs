using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1
{
    class Zoo : IZoo
    {
        public List<Animal> Animals = new List<Animal>();
        public string Name = "This zoo has no name";

        public string Sounds()
        {
            string sounds = "";
            Animals.ForEach(delegate(Animal animal)
            {
                sounds += animal.Sound();
            });
            return sounds;
        }
    }
}
