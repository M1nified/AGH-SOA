using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class AuthorsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Author> Get()
        {
            using (var dbContext = new DAL.StoreContext())
            {
                return dbContext.Authors.ToList();
            }
        }

        // GET api/<controller>/5
        public Author Get(int id)
        {
            using (var dbContext = new DAL.StoreContext())
            {
                return dbContext.Authors.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        // POST api/<controller>
        public int Post([FromBody]Author value)
        {
            using (var dbContext = new DAL.StoreContext())
            {
                dbContext.Authors.Add(value);
                dbContext.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = value.Id }, value).Content.Id;
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Author value)
        {
            using (var dbContext = new DAL.StoreContext())
            {
                var element = dbContext.Authors.Where(x => x.Id == id).FirstOrDefault();
                element.AuthorName = value.AuthorName;
                element.AuthorSurname = value.AuthorSurname;
                dbContext.SaveChanges();
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            using(var dbContext = new DAL.StoreContext())
            {
                dbContext.Authors.Remove(dbContext.Authors.Where(x => x.Id == id).FirstOrDefault());
                dbContext.SaveChanges();
            }
        }
    }
}