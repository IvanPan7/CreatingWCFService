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
               System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(HotelBookingService));
                host.Opened += new EventHandler((o, a) =>
                {
                    Console.WriteLine("Felicidades se alojó tu servicio");
                    foreach (var item in host.Description.Endpoints)
                    {
                        Console.WriteLine(item.ListenUri);
                    }
                });
                host.Open();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Falló el alojamiento del servicio: {0}", ex);
            }

            Console.ReadLine();
        }
    }
}
