using System.Collections.Generic;
using System.ServiceModel;
using ObjectManager.Models;
using ObjectManager.LiteDB;
using System.Linq;

namespace HobbitsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Palantir : IPalantirWCF
    {
        public List<Position> GetRanks()
        {
            var repo = new PostionsRepository();
            return repo.GetAll().OrderBy(x => x.Gold).ToList();
        }

        public void SetPlayerRank(string name, int gold)
        {
            var repo = new PostionsRepository();
            var position = repo.Get(name);
            position.Gold = gold;
            repo.Update(position);
        }
    }
}
