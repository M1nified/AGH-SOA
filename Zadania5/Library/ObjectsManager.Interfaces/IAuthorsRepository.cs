using ObjectsManager.Model;
using System.Collections.Generic;

namespace ObjectsManager.Interfaces
{
    public interface IAuthorsRepository
    {
        int Add(Author author);
        bool Delete(int id);
        List<Author> GetAll();
        bool Update(int id, Author author);
    }
}
