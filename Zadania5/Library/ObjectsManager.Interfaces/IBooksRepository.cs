using ObjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsManager.Interfaces
{
    public interface IBooksRepository
    {
        int Add(Book book);
        bool Delete(int id);
        List<Book> GetAll();
        bool Update(int id, Book book);
    }
}
