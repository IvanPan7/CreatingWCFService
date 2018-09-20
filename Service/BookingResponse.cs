using System.Runtime.Serialization;

namespace Service
{
    [DataContract]
    public class BookingResponse
    {
        [DataMember]
        public bool IsApproved { get; set; }
        [DataMember]
        public string BookingReference { get; set; }
    }
}