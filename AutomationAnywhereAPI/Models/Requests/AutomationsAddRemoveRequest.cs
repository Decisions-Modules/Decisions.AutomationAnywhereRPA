using System.Runtime.Serialization;

namespace AutomationAnywhereAPI.Models.Requests
{
    [DataContract]
    public class AutomationsAddRemoveRequest
    {

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "child_ids")]
        public int[] ChildIds { get; set; }
    }
}
