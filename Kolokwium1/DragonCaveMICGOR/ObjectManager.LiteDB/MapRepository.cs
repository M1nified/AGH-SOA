using LiteDB;
using ObjectManager.Interfaces;
using ObjectManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectManager.LiteDB
{
    public class MapRepository : IMapRepository
    {
        private readonly string _treasuresConnection = DatabaseConnections.TreasuresConnection;

        public int Add(Location treasure)
        {
            using(var db = new LiteDatabase(_treasuresConnection))
            {
                var repository = db.GetCollection<Location>("treasures");
                if (repository.FindById(treasure.Id) != null)
                    repository.Update(treasure);
                else
                    repository.Insert(treasure);

                return treasure.Id;
            }
        }
    }
}
