using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1
{
    class Ant : Animal
    {
        bool IsQueen;
        public override string Sound()
        {
            return "Mruu";
        }
        public override string Trick()
        {
            return "Ruch czulkami";
        }
        public override int CountLegs()
        {
            return 6;
        }
    }
}
