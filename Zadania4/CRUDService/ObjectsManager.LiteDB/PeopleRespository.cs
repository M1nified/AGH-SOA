using ObjectsManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectsManager.Model;
using ObjectsManager.LiteDB.Model;

namespace ObjectsManager.LiteDB
{
    class PeopleRespository : IPeopleRepository
    {
        public int Add(Person person)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public Person Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
        public static Person Map(PersonDB dbPerson)
        {
            if (dbPerson == null)
                return null;
            return new Person() { Id = dbPerson.Id, Name = dbPerson.Name, Surname = dbPerson.Surname };
        }
    }
}
