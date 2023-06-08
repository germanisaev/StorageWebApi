using System.Runtime.Serialization;

namespace ExamWebApi.Models.Storages {
    public enum StatusEnum {
        [EnumMember]
        Active = 1,
        [EnumMember]
        Completed = 2,
        [EnumMember]
        Cancelled = 3,
        [EnumMember]
        Blocked = 4
    }
}