using System.Runtime.Serialization;

namespace AutomationAnywhereAPI.Models.Requests
{
    [DataContract]
    public class FilterAutomationsList
    {
        [DataMember(Name = "operator")]
        public string Operator { get; set; }

        [DataMember(Name = "field")]
        public string Field { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }
    }

    [DataContract]
    public class AutomationsListRequest
    {
        [DataMember(Name = "filter")]
        public FilterAutomationsList Filter { get; set; }
    }
}
