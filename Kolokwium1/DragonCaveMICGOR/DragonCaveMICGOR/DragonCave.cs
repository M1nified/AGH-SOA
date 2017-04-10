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
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class DragonCave : IDragonCave
    {
        public Treasure GetLoot()
        {
            var items = new string[]{ "szata", "bron", "czapka" };
            var tr = new Treasure()
            {
                Gold = new Random().Next(0, 100),
                Item = items[new Random().Next(0, 2)]
            };
            var repo = new ObjectManager.LiteDB.TreasureRepository();
            var id = repo.Add(tr);
            tr.Id = id;
            return tr;
        }
    }
}
