using ObjectManager.Models;
using System.Collections.Generic;

namespace ObjectManager.Interfaces
{
    public interface IPositionsRepository
    {
        List<Position> GetAll();
        Position Add(Position position);
        Position Get(string positionName);
        Position Update(Position position);
        bool Delete(string positionName);
    }
}
