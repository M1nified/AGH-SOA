using LiteDB;
using ObjectManager.Interfaces;
using ObjectManager.LiteDB.Models;
using ObjectManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectManager.LiteDB
{
    public class PostionsRepository : IPositionsRepository
    {
        private readonly string _connection = DatabaseConnections.PositionsConnection;

        public Position Add(Position position)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<PositionDb>("positions");
                var dbPosition = MapReverse(position);
                if (repository.FindOne(x => x.Name == position.Name) != null)
                    repository.Update(dbPosition);
                else
                    repository.Insert(dbPosition);
                return position;
            }
        }

        public bool Delete(string positionName)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<PositionDb>("positions");
                return 0 < repository.Delete(x => x.Name == positionName);
            }
        }

        public Position Get(string positionName)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<PositionDb>("positions");
                return Map(repository.FindOne(x => x.Name == positionName));
            }
        }

        public List<Position> GetAll()
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<PositionDb>("positions");
                var dbPositions = repository.FindAll().ToList();
                var positions = new List<Position>();
                dbPositions.ForEach(x => positions.Add(Map(x)));
                return positions;
            }
        }

        public Position Update(Position position)
        {
            using (var db = new LiteDatabase(_connection))
            {
                var repository = db.GetCollection<PositionDb>("positions");
                var dbPosition = MapReverse(position);
                repository.Update(dbPosition);
                return position;
            }
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
