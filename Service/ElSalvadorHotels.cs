using System.Runtime.Serialization;

namespace Service
{
    [DataContract]
    public class ElSalvadorHotels
    {
        [DataMember]
        public int IDHotel { get; set; }
        [DataMember]
        public string NameHotel { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string DepartmentLocation { get; set; }
    }
}