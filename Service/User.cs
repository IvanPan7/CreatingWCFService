using System.Runtime.Serialization;

namespace Service
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string NameUser { get; set; }
        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Request { get; set; }
    }
}