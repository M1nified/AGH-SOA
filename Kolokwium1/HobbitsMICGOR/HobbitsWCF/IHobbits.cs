using ObjectManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HobbitsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHobbits
    {
        [OperationContract]
        int CreatePlayer(string name, string code);
        [OperationContract]
        int GetPlayer(string name, string code);
        [OperationContract]
        string GetPlayerName(int id);
        [OperationContract]
        Stats GetPlayerStats(string name);
    }

}
