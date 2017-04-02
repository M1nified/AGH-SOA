using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectsManager.Model;
using System.ServiceModel;

namespace CRUDService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MoviesService : IMoviesService
    {
        public int AddMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAllMovies()
        {
            throw new NotImplementedException();
        }
    }
}
