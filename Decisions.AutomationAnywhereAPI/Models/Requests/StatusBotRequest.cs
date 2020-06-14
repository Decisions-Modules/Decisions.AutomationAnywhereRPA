using System.Runtime.Serialization;

namespace Decisions.AutomationAnywhereAPI.Models.Requests
{
    [DataContract]
    public class OperandStatusBot
    {

        [DataMember(Name = "operator")]
        public string Operator { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        [DataMember(Name = "field")]
        public string Field { get; set; }
    }

    [DataContract]
    public class FilterStatusBot
    {

        [DataMember(Name = "operator")]
        public string Operator { get; set; }

        [DataMember(Name = "operands")]
        public OperandStatusBot[] Operands { get; set; }
    }

    [DataContract]
    public class StatusBotRequest
    {

        [DataMember(Name = "filter")]
        public FilterStatusBot Filter { get; set; }
    }
}
