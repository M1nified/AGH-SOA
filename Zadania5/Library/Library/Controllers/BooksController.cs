using ObjectsManager.LiteDB;
using ObjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Library.Controllers
{
    public class BooksController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Book> Get()
        {
            return new BooksRepository().GetAll();
        }

        // GET api/<controller>/5
        public Book Get(int id)
        {
            return new BooksRepository().GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Book> Get(string search)
        {
            return new BooksRepository().GetAll().Where(x => x.BookTitle.Contains(search)).ToList();
        }

        // POST api/<controller>
        public int Post([FromBody]Book value)
        {
            return new BooksRepository().Add(value);
        }

        // PUT api/<controller>
        public void Put(int id, [FromBody]Book value)
        {
            new BooksRepository().Update(id, value);
        }

        // DELETE api/<controller>
        public void Delete([FromBody]Book value)
        {
            new BooksRepository().Delete(value.Id);
        }
    }
}