using ObjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsManager.Interfaces
{
    public interface IPeopleRepository
    {
        List<Person> GetAll();
        int Add(Person person);
        Person Get(int Id);
        Person Update(Person person);
        bool Delete(Person person);
    }
}
