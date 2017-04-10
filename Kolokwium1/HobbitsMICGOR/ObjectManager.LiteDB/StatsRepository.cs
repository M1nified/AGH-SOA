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
            throw new NotImplementedException();
        }

        public void Delete(int statsId)
        {
            throw new NotImplementedException();
        }

        public int Get(int statsId)
        {
            throw new NotImplementedException();
        }

        public int Update(Stats stats)
        {
            throw new NotImplementedException();
        }
    }
}
