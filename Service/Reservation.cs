using System;
using System.Runtime.Serialization;

namespace Service
{
    [DataContract]
    public class Reservation
    {
        [DataMember]
        public string HotelName { get; set; }
        [DataMember]
        public string GuestName { get; set; }
        [DataMember]
        public DateTime CheckInDate { get; set; }
    }
}