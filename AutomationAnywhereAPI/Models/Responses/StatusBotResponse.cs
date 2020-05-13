using System;
using System.Runtime.Serialization;

namespace AutomationAnywhereAPI.Models.Responses
{
    [DataContract]
    public class VMyHelloWorld
    {

        [DataMember(Name = "string")]
        public string String { get; set; }
    }

    [DataContract]
    public class OutputVariables
    {

        [DataMember(Name = "vMyHelloWorld")]
        public VMyHelloWorld vMyHelloWorld { get; set; }
    }

    [DataContract]
    public class ListStatusBot
    {

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "automationName")]
        public string AutomationName { get; set; }

        [DataMember(Name = "fileName")]
        public string FileName { get; set; }

        [DataMember(Name = "filePath")]
        public string FilePath { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "startDateTime")]
        public DateTime StartDateTime { get; set; }

        [DataMember(Name = "endDateTime")]
        public DateTime EndDateTime { get; set; }

        [DataMember(Name = "command")]
        public string Command { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "progress")]
        public int Progress { get; set; }

        [DataMember(Name = "automationId")]
        public string AutomationId { get; set; }

        [DataMember(Name = "userId")]
        public string UserId { get; set; }

        [DataMember(Name = "deviceId")]
        public string DeviceId { get; set; }

        [DataMember(Name = "currentLine")]
        public int CurrentLine { get; set; }

        [DataMember(Name = "totalLines")]
        public int TotalLines { get; set; }

        [DataMember(Name = "fileId")]
        public string FileId { get; set; }

        [DataMember(Name = "modifiedBy")]
        public string ModifiedBy { get; set; }

        [DataMember(Name = "createdBy")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "modifiedOn")]
        public DateTime ModifiedOn { get; set; }

        [DataMember(Name = "createdOn")]
        public DateTime CreatedOn { get; set; }

        [DataMember(Name = "deploymentId")]
        public string DeploymentId { get; set; }

        [DataMember(Name = "queueName")]
        public string QueueName { get; set; }

        [DataMember(Name = "queueId")]
        public string QueueId { get; set; }

        [DataMember(Name = "usingRdp")]
        public bool UsingRdp { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "canManage")]
        public bool CanManage { get; set; }

        [DataMember(Name = "deviceName")]
        public string DeviceName { get; set; }

        [DataMember(Name = "userName")]
        public string UserName { get; set; }

        [DataMember(Name = "isMigrated")]
        public bool IsMigrated { get; set; }

        [DataMember(Name = "jobUniqueId")]
        public string JobUniqueId { get; set; }

        [DataMember(Name = "outputVariables")]
        public OutputVariables OutputVariables { get; set; }
    }

    [DataContract]
    public class StatusBotResponse
    {

        [DataMember(Name = "page")]
        public Page Page { get; set; }

        [DataMember(Name = "list")]
        public ListStatusBot[] List { get; set; }
    }
}
