using ObjectManager.Models;
using System.Collections.Generic;

namespace ObjectManager.Interfaces
{
    public interface IPositionsRepository
    {
        List<Position> GetAll();
        int Add(Position position);
        Position Get(int Id);
        Position Update(Position position);
        bool Delete(int Id);
    }
}
