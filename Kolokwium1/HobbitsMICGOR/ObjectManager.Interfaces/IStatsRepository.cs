using ObjectManager.Models;

namespace ObjectManager.Interfaces
{
    public interface IStatsRepository
    {
        int Add(Stats stats);
        Stats Get(int statsId);
        bool Update(Stats stats);
        bool Delete(int statsId);

    }
}
