using ObjectManager.Models;

namespace ObjectManager.Interfaces
{
    public interface IPlayersRepository
    {
        int Add(Player player);
        Player Get(int playerId);
        bool Update(Player player);
        bool Delete(int playerId);
    }
}
