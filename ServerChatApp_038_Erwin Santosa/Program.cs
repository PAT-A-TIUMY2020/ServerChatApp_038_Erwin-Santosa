using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFService_2Way_038;

namespace ServerChatApp_038_Erwin_Santosa
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObject = null;
            try
            {
                hostObject = new ServiceHost(typeof(ServiceCallback));
                hostObject.Open();

                Console.WriteLine("Server ON, Ready to use");
                Console.ReadLine();

                hostObject.Close();
            }
            catch (Exception ex)
            {
                hostObject = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

    }


}
