using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectsManager.Interfaces;
using ObjectsManager.Model;
using ObjectsManager.LiteDB.Model;

namespace ObjectsManager.LiteDB
{
    public class ReviewsRepository : IReviewsRepository
    {
        public int Add(Review person)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Review review)
        {
            throw new NotImplementedException();
        }

        public Review Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAll()
        {
            throw new NotImplementedException();
        }

        public Review Update(Review person)
        {
            throw new NotImplementedException();
        }

        internal Review Map(ReviewDB dbReview)
        {
            if (dbReview == null)
                return null;
            return new Review()
            {
                Author = PeopleRespository.Map(dbReview.Author),
                Content = dbReview.Content, Id = dbReview.Id, MovieId = dbReview.MovieId, Score = dbReview.Score
            };
        }
    }
}
