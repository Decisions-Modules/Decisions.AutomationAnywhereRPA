using System.Runtime.Serialization;
namespace Decisions.AutomationAnywhereAPI.Models.Requests
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
