using System.Runtime.Serialization;

namespace AutomationAnywhereAPI.Models.Requests
{
    [DataContract]
    public class ListUsersRequest
    {

        [DataMember(Name = "fields")]
        public object[] Fields { get; set; }

        [DataMember(Name = "filter")]
        public Filter Filter { get; set; }
    }

    [DataContract]
    public class Operand
    {
        [DataMember(Name = "operator")]
        public string Operator { get; set; }

        [DataMember(Name = "field")]
        public string Field { get; set; }

        [DataMember(Name = "value")]
        public object Value { get; set; }
    }

    [DataContract]
    public class Filter
    {
        [DataMember(Name = "operator")]
        public string Operator { get; set; }

        [DataMember(Name = "operands")]
        public Operand[] operands { get; set; }
    }
}
