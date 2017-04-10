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
    public class TreasureRepository : ITreasuresRespository
    {
        private readonly string _treasuresConnection = DatabaseConnections.TreasuresConnection;

        public int Add(Treasure treasure)
        {
            using(var db = new LiteDatabase(_treasuresConnection))
            {
                var repository = db.GetCollection<Treasure>("treasures");
                if (repository.FindById(treasure.Id) != null)
                    repository.Update(treasure);
                else
                    repository.Insert(treasure);

                return treasure.Id;
            }
        }
    }
}
