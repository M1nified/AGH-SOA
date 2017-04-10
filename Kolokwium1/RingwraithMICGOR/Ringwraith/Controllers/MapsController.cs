using ObjectManager.LiteDB;
using ObjectManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RingwraithMICGOR.Controllers
{
    public class MapsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Map> Get()
        {
            return new MapRepository().FindAll();
        }

        // GET api/<controller>/5
        public Map Get(int id)
        {
            return new MapRepository().FindAll().Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/<controller>
        public int Post([FromBody]Map value)
        {
            return new MapRepository().Add(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Map value)
        {
            new MapRepository().Add(value);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            new MapRepository().Delete(id);
        }
    }
}