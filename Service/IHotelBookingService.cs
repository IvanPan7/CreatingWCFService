using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Service
{
    //Esta interfaz pasa a ser un servicio de WCF
    [ServiceContract]
    public interface IHotelBookingService
    {
        [OperationContract]
        BookingResponse BookHotel(Reservation reservation);

        [OperationContract]
        bool Authenticate(User user);

        [OperationContract]
        List<ElSalvadorHotels> GetHotelsList(User user);

        [OperationContract]
        List<ElSalvadorHotels> GetHotelsListByCategory(User user);

        [OperationContract]
        List<ElSalvadorHotels> GetHotelsListByLocation(User user);
    }
}
