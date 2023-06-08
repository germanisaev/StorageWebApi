using System;

namespace ExamWebApi.Models.Storages {
    public class StorageDTO {
        public int StorageId { get; set; }
        public DateTime StorageDate { get; set; }
        public int StorageStatus { get; set; }  
        public int StorageAmount { get; set; } 
    }
}