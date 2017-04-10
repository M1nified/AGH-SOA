using ObjectManager.Models;

namespace ObjectManager.Interfaces
{
    public interface IStatsRepository
    {
        int Add(Stats stats);
        int Get(int statsId);
        int Update(Stats stats);
        void Delete(int statsId);

    }
}
