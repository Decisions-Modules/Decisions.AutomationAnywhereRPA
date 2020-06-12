using System.Runtime.Serialization;

namespace Decisions.AutomationAnywhereAPI.Models
{
    [DataContract]
    public class Role
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "version")]
        public int Version { get; set; }
    }
}
