using ObjectManager.Models;
using System.Collections.Generic;

namespace ObjectManager.Interfaces
{
    public interface IMapRepository
    {
        int Add(Map map);
        List<Map> FindAll();
    }
}
