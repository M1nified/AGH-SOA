using ObjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsManager.Interfaces
{
    public interface IReviewsRepository
    {
        List<Review> GetAll();
        int Add(Review person);
        Review Get(int Id);
        Review Update(Review person);
        bool Delete(Review review);
    }
}
