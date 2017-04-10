using ObjectManager.Models;

namespace ObjectManager.Interfaces
{
    public interface IPlayersRepository
    {
        int Add(Player player);
        int Get(int playerId);
        int Update(Player player);
        void Delete(int playerId);
    }
}
