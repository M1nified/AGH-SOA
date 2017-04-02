using ObjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsManager.Interfaces
{
    public interface IMoviesRepository
    {
        List<Movie> GetAll();
        int Add(Movie movie);
        Movie Get(int Id);
        Movie Update(Movie movie);
        bool Delete(int Id);
    }
}
