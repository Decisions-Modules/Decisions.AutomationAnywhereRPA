using System;
using System.Runtime.Serialization;

namespace AutomationAnywhereAPI.Models.Responses
{

    [DataContract]
    public class Permission
    {

        [DataMember(Name = "delete")]
        public bool Delete { get; set; }

        [DataMember(Name = "download")]
        public bool Download { get; set; }

        [DataMember(Name = "execute")]
        public bool Execute { get; set; }

        [DataMember(Name = "upload")]
        public bool Upload { get; set; }

        [DataMember(Name = "run")]
        public bool Run { get; set; }
    }

    [DataContract]
    public class List
    {

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "parentid")]
        public string Parentid { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "permission")]
        public Permission Permission { get; set; }

        [DataMember(Name = "lastModified")]
        public DateTime LastModified { get; set; }

        [DataMember(Name = "lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [DataMember(Name = "path")]
        public string Path { get; set; }

        [DataMember(Name = "directory")]
        public bool Directory { get; set; }

        [DataMember(Name = "size")]
        public int Size { get; set; }

        [DataMember(Name = "locked")]
        public bool Locked { get; set; }

        [DataMember(Name = "fileLastModified")]
        public DateTime FileLastModified { get; set; }

        [DataMember(Name = "isProtected")]
        public bool IsProtected { get; set; }
    }

    [DataContract]
    public class AutomationsListResponse
    {

        [DataMember(Name = "page")]
        public Page Page { get; set; }

        [DataMember(Name = "list")]
        public List[] List { get; set; }
    }
}
