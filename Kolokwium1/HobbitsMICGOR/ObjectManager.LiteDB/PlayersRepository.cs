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
    public class PlayersRepository : IPlayersRepository
    {
        private readonly string _connection = DatabaseConnections.PlayersConnection;

        public int Add(Player player)
        {
            using(var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Player>("players");

            }
        }

        public void Delete(int playerId)
        {
            throw new NotImplementedException();
        }

        public int Get(int playerId)
        {
            throw new NotImplementedException();
        }

        public int Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
