using System.Runtime.Serialization;

namespace Decisions.AutomationAnywhereAPI.Models.Requests
{
    [DataContract]
    public class StartBotRequest
    {

        [DataMember(Name = "fileId")]
        public string FileId { get; set; }

        [DataMember(Name = "deviceIds")]
        public string[] DeviceIds { get; set; }
    }
}
