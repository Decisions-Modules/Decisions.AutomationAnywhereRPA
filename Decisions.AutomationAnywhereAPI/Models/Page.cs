using System.Runtime.Serialization;

namespace Decisions.AutomationAnywhereAPI.Models
{
    [DataContract]
    public class Page
    {

        [DataMember(Name = "offset")]
        public int Offset { get; set; }

        [DataMember(Name = "total")]
        public int Total { get; set; }

        [DataMember(Name = "totalFilter")]
        public int TotalFilter { get; set; }
    }
}
