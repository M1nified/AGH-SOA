using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CosmicAdventureDTO
{
    [DataContract]
    public class Starship
    {
        [DataMember]
        public List<Person> Crew = new List<Person>();
        [DataMember]
        public int Gold;
        [DataMember]
        public int ShipPower;
    }
}
