using System.Runtime.Serialization;

namespace Decisions.AutomationAnywhereAPI.Models
{
    [DataContract]
    public class Connection
    {
        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "user")]
        public User User { get; set; }

        [DataMember(Name = "credentials")]
        public Credentials Credentials { get; set; }
    }

    [DataContract]
    public class Credentials
    {

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "password")]
        public string Password { get; set; }
    }
}
