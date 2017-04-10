using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ObjectManager.Models;

namespace HobbitsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Palantir : IPalantirWCF
    {
        public List<Position> GetRanks()
        {
            throw new NotImplementedException();
        }

        public void SetPlayerRank(string name, int gold)
        {
            throw new NotImplementedException();
        }
    }
}
