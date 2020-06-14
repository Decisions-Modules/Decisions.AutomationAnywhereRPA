using System.Runtime.Serialization;

namespace Decisions.AutomationAnywhereAPI.Models.Requests
{
    [DataContract]
    public class CreateUserRequest
    {

        [DataMember(Name = "roles")]
        public Role[] Roles { get; set; }

        [DataMember(Name = "enableAutoLogin")]
        public bool EnableAutoLogin { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "password")]
        public string Password { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "licenseFeatures")]
        public string[] LicenseFeatures { get; set; }
    }

    [DataContract]
    public class Role
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
    }
}
