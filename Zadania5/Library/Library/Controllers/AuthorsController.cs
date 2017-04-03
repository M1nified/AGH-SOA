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
    public class AuthorsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Author> Get()
        {
            return new AuthorsRepository().GetAll();
        }

        // GET api/<controller>/5
        public Author Get(int id)
        {
            return new AuthorsRepository().GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/<controller>
        public int Post([FromBody]Author value)
        {
            return new AuthorsRepository().Add(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Author value)
        {
            new AuthorsRepository().Update(id, value);
        }

        // DELETE api/<controller>/5
        public void Delete(Author value)
        {
            new AuthorsRepository().Delete(value.Id);
        }
    }
}