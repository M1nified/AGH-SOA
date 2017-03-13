using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri address = new Uri("http://localhost:80/Temporary_Listen_Addresses/WCFTest");
            ServiceHost selfHost = new ServiceHost(typeof(BlackHole), address);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IBlackHole), new WSHttpBinding(), "BlackHoleServiceEndpoint");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);
                selfHost.Open();
                Console.WriteLine("Working");
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
