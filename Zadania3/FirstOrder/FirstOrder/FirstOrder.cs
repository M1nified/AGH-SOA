using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirstOrder
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class FirstOrder : IFirstOrder
    {
        public int GetMoneyFromImperium()
        {
            Random random = new Random();
            return random.Next(3000, 5000);
        }
    }
}
