using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CosmicAdventureDTO
{
    [DataContract]
    public class SpaceSystem
    {
        [DataMember]
        public string Name;
        public  int MinShipPower;
        [DataMember]
        public int BaseDistance;
        public int Gold;
    }
}
