using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Service;

namespace ServiceHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Uri tcpURI = new Uri("net.tcp//localhost:80/");
                System.ServiceModel.ServiceHost host =  
                    new System.ServiceModel.ServiceHost(typeof(Service.HotelBookingService),tcpURI);
                host.AddServiceEndpoint(typeof(Service.IHotelBookingService),new NetTcpBinding(), "booking");
                host.Opened += new EventHandler((o, a) => Console.WriteLine());
                host.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falló el alojamiento del servicio", ex);
                throw ex;
            }
            Console.ReadLine();
        }
    }
}
