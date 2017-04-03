using System;
using System.Collections.Generic;
using ObjectsManager.Interfaces;
using ObjectsManager.Model;
using LiteDB;
using System.Linq;

namespace ObjectsManager.LiteDB
{
    public class AuthorsRepository : IAuthorsRepository
    {
        private readonly string _authorConnection = DatabaseConnections.AuthorsConnection;

        public int Add(Author author)
        {
            using (var db = new LiteDatabase(this._authorConnection))
            {
                var repository = db.GetCollection<Author>("authors");
                var result = repository.Insert(author);
                return result;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(this._authorConnection))
            {
                var repository = db.GetCollection<Author>("authors");
                var result = repository.Delete(id);
                return result;
            }
        }

        public List<Author> GetAll()
        {
            using (var db = new LiteDatabase(this._authorConnection))
            {
                var repository = db.GetCollection<Author>("authors");
                var result = repository.FindAll().ToList();
                return result;
            }
        }

        public bool Update(int id, Author author)
        {
            using (var db = new LiteDatabase(this._authorConnection))
            {
                var repository = db.GetCollection<Author>("authors");
                var result = repository.Update(id, author);
                return result;
            }
        }
    }
}
