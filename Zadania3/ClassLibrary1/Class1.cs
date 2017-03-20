using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [DataContract]
    class SpaceSystem
    {
        [DataMember]
        public string Name;
        private int MinShipPower;
        [DataMember]
        public int BaseDistance;
        private int Gold;
    }
}
