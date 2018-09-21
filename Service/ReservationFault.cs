using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [DataContract]
    public class ReservationFault
    {
        [DataMember]
        public string HotelName { get; set; }
        [DataMember]
        public string ErrorCode { get; set; }
    }
}
