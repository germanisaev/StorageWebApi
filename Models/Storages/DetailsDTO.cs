using System;
using System.Collections.Generic;

namespace ExamWebApi.Models.Storages {
    public class DetailsDTO {
        public IEnumerable<StorageDTO> StorageDetails { get; set; }
        public IEnumerable<StatusDTO> StatusDetails { get; set; } 
    }
}