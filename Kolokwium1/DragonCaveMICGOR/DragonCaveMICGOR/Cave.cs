using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ObjectManager.Models;

namespace DragonCaveMICGOR
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Cave : ICave
    {
        private List<Gamer> _players = new List<Gamer>();
        private Map _mapObject;

        public Location Init(string playerName)
        {
            var gamer = new Gamer()
            {
                CurrentPosition = 24
            };
        }

        public Location Move(int kierunek, string playerName)
        {
            throw new NotImplementedException();
        }

        public int UserKey(int kierunek, string secretKey)
        {
            throw new NotImplementedException();
        }
    }
}
