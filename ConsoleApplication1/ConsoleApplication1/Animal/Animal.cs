using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal
    {
        public string Name;
        public float Weight;
        public bool HasFur;

        public virtual string Sound()
        {
            throw new NotImplementedException();   
        }
        public virtual string Trick()
        {
            throw new NotImplementedException();
        }
        public virtual int CountLegs()
        {
            throw new NotImplementedException();
        }

    }
}
