using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class BooksController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Book> Get()
        {
            using(var dbContext = new DAL.StoreContext())
            {
                return dbContext.Books.ToList();
            }
        }

        // GET api/<controller>/5
        public Book Get(int id)
        {
            using (var dbContext = new DAL.StoreContext())
            {
                return dbContext.Books.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        // POST api/<controller>
        public int Post([FromBody]Book value)
        {
            using (var dbContext = new DAL.StoreContext())
            {
                dbContext.Books.Add(value);
                dbContext.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = value.Id }, value).Content.Id;
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Book value)
        {
            using (var dbContext = new DAL.StoreContext())
            {
                var element = dbContext.Books.Where(x => x.Id == id).FirstOrDefault();
                element.BookTitle = value.BookTitle;
                element.ISBN = value.ISBN;
                dbContext.SaveChanges();
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            using(var dbContext = new DAL.StoreContext())
            {
                dbContext.Books.Remove(dbContext.Books.Where(x => x.Id == id).FirstOrDefault());
                dbContext.SaveChanges();
            }
        }
    }
}