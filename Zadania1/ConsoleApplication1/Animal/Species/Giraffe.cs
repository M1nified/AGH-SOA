using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1
{
    class Giraffe : Animal
    {
        public override string Sound()
        {
            return "Weee";
        }
        public override string Trick()
        {
            return "Ruch glowa";
        }
        public override int CountLegs()
        {
            return 4;
        }
    }
}
