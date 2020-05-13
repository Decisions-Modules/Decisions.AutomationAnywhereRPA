using System.Runtime.Serialization;

namespace AutomationAnywhereAPI.Models.Responses
{
    [DataContract]
    public class AuthResponse
    {

        [DataMember(Name = "token")]
        public string Token { get; set; }

        [DataMember(Name = "user")]
        public User User { get; set; }
    }
}
