using ObjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CRUDService
{
    [ServiceContract]
    interface IMoviesService
    {
        [OperationContract]
        List<Movie> GetAllMovies();
        [OperationContract]
        int AddMovie(Movie movie);
    }
}
