using LiteDB;
using ObjectManager.Interfaces;
using ObjectManager.LiteDB.Models;
using ObjectManager.Models;
using System;
using System.Collections.Generic;

namespace ObjectManager.LiteDB
{
    public class PostionsRepository : IPositionsRepository
    {
        private readonly string _connection = DatabaseConnections.PositionsConnection;

        public int Add(Position position)
        {
            using(var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<PositionDb>("positions");
                //if (repository.FindOne(x => x.Name == position.Name) != null)
                //    repository.Update(position);
                //else
                var dbPosition = MapReverse(position);
                repository.Insert(dbPosition);
                return dbPosition.Id;
            }
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Position Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Position> GetAll()
        {
            throw new NotImplementedException();
        }

        public Position Update(Position movie)
        {
            throw new NotImplementedException();
        }

        public static Position Map(PositionDb dbPosition)
        {
            if (dbPosition == null)
                return null;
            return new Position() { Name = dbPosition.Name, Gold = dbPosition.Gold };
        }

        public static PositionDb MapReverse(Position position)
        {
            if (position == null)
                return null;
            return new PositionDb() { Name = position.Name, Gold = position.Gold };
        }
    }
}
