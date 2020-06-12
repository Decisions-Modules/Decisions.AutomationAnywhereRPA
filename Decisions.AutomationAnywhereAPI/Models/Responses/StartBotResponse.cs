using System.Runtime.Serialization;

namespace Decisions.AutomationAnywhereAPI.Models.Responses
{
    [DataContract]
    public class StartBotResponse
    {

        [DataMember(Name = "automationId")]
        public string AutomationId { get; set; }
    }
}
