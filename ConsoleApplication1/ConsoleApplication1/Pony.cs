using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pony : Animal
    {
        bool IsMagic;
        public override string Sound()
        {
            return "Icha";
        }
        public override string Trick()
        {
            return "Kopytkowanie";
        }
        public override int CountLegs()
        {
            return 4;
        }
    }
}
