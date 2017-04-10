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
    public class Hobbits : IPalantirWCF
    {
        public int CreatePlayer(string name, string code)
        {
            throw new NotImplementedException();
        }

        public int GetPlayer(string name, string code)
        {
            throw new NotImplementedException();
        }

        public string GetPlayerName(int id)
        {
            throw new NotImplementedException();
        }

        public Position GetPlayerStats(string name)
        {
            throw new NotImplementedException();
        }
    }
}
