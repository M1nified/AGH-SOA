using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Zoo : IZoo
    {
        public List<Animal> Animals;
        public string Name;

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
