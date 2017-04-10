using LiteDB;
using ObjectManager.Interfaces;
using ObjectManager.Models;
using System;

namespace ObjectManager.LiteDB
{
    public class StatsRepository : IStatsRepository
    {
        private readonly string _connection = DatabaseConnections.StatsConnection;

        public int Add(Stats stats)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Stats>("stats");
                if (repository.FindById(stats.Id) != null)
                    repository.Update(stats);
                else
                    repository.Insert(stats);
                return stats.Id;
            }
        }

        public bool Delete(int statsId)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Stats>("stats");
                return repository.Delete(statsId);
            }
        }

        public Stats Get(int statsId)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Stats>("stats");
                return repository.FindById(statsId);
            }
        }

        public bool Update(Stats stats)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Stats>("stats");
                return repository.Update(stats);
            }
        }
    }
}
