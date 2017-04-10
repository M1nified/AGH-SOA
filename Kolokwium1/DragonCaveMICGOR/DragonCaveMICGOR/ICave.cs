using ObjectManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DragonCaveMICGOR
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICave
    {
        [OperationContract]
        Location Init(string playerName);
        [OperationContract]
        Location Move(int kierunek, string playerName);
        [OperationContract]
        int UserKey(int kierunek, string secretKey);
    }

}
