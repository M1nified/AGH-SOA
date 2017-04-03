using System;
using System.Collections.Generic;
using ObjectsManager.Interfaces;
using ObjectsManager.Model;
using LiteDB;
using System.Linq;

namespace ObjectsManager.LiteDB
{
    public class BooksRepository : IBooksRepository
    {
        private readonly string _booksConnection = DatabaseConnections.BooksConnection;

        public int Add(Book book)
        {
            using(var db = new LiteDatabase(this._booksConnection))
            {
                var repository = db.GetCollection<Book>("books");
                var result = repository.Insert(book);
                return result;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(this._booksConnection))
            {
                var repository = db.GetCollection<Book>("books");
                var result = repository.Delete(id);
                return result;
            }
        }

        public List<Book> GetAll()
        {
            using (var db = new LiteDatabase(this._booksConnection))
            {
                var repository = db.GetCollection<Book>("books");
                var result = repository.FindAll().ToList();
                return result;
            }
        }

        public bool Update(int id, Book book)
        {
            using (var db = new LiteDatabase(this._booksConnection))
            {
                var repository = db.GetCollection<Book>("books");
                var result = repository.Update(id, book);
                return result;
            }
        }
    }
}
