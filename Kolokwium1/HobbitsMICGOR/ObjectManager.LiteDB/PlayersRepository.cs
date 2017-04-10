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
                if (repository.FindById(player.Id) != null)
                    repository.Update(player);
                else
                    repository.Insert(player);
                return player.Id;
            }
        }

        public bool Delete(int playerId)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Player>("players");
                return repository.Delete(playerId);
            }
        }

        public Player Get(int playerId)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Player>("players");
                return repository.FindById(playerId);
            }
        }

        public bool Update(Player player)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<Player>("players");
                return repository.Update(player);
            }
        }
    }
}
