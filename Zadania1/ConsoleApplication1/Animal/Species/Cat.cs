using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1
{
    class Cat : Animal
    {
        string Color;
        public override string Sound()
        {
            return "Miau";
        }
        public override string Trick()
        {
            return "Ruch ogonem";
        }
        public override int CountLegs()
        {
            return 4;
        }
    }
}
