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
        private readonly string _connection = DatabaseConnections.MapsConnection;

        public int Add(Map map)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Map>("maps");
                if (repository.FindById(map.Id) != null)
                    repository.Update(map);
                else
                    repository.Insert(map);

                return map.Id;
            }
        }

        public bool Delete(int mapId)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Map>("maps");
                return repository.Delete(mapId);
            }
        }

        public List<Map> FindAll()
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Map>("maps");
                return repository.FindAll().ToList<Map>();
            }
        }
    }
}
