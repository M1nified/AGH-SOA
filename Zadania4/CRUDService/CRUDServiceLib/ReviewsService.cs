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
    class ReviewsService : IReviewsService
    {
        public int AddMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public int AddReview(IReviewsService review)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReview(Review review)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetReviewsForMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetReviewsForUser(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
