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
    interface IReviewsService
    {
        [OperationContract]
        int AddReview(IReviewsService review);
        [OperationContract]
        List<Review> GetReviewsForUser(Person person);
        [OperationContract]
        bool DeleteReview(Review review);
        [OperationContract]
        List<Review> GetReviewsForMovie(Movie movie);
        [OperationContract]
        int AddMovie(Movie movie);
    }
}
