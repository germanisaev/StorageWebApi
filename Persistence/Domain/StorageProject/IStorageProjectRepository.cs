using System.Collections.Generic;
using System.Threading.Tasks;
using ExamWebApi.Models.Storages;

namespace ExamWebApi.Persistence.Domain.StorageProject {
    public interface IStorageProjectRepository
    {
        Task<IEnumerable<StorageDTO>> GetAllStorages();
        Task<StorageDTO> GetStorageBy(string storageBy);
    }
}