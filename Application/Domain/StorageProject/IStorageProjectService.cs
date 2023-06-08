using System.Collections.Generic;
using System.Threading.Tasks;
using ExamWebApi.Models.Storages;

namespace ExamWebApi.Application.Domain.StorageProject
{
    public interface IStorageProjectService
    {
        Task<IEnumerable<StorageDTO>> GetAllStorages();
        Task<StorageDTO> GetStorageBy(string storageId);
    }
}