using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamWebApi.Models.Storages;
using ExamWebApi.Persistence.Domain.StorageProject;
using Microsoft.Extensions.Logging;

namespace ExamWebApi.Application.Domain.StorageProject {

    public class StorageProjectService: IStorageProjectService {

        private readonly ILogger<StorageProjectService> _logger;
        //private readonly IStorageProjectRepository _repository;
        //private readonly IMapper _mapper;
        public StorageProjectService(ILogger<StorageProjectService> logger) {//, IStorageProjectRepository repository) {
            _logger = logger;
            //_repository = repository;
        }

        public async Task<IEnumerable<StorageDTO>> GetAllStorages() {
            IEnumerable<StorageDTO> storageDetails = null;

            storageDetails = Enumerable.Range(1, 3).Select(index => new StorageDTO
            {
                StorageId = index,
                StorageDate = DateTime.Now.AddDays(index),
                StorageStatus = index,
                StorageAmount = index
            })
            .ToArray();

            return storageDetails;
        }

        public async Task<StorageDTO> GetStorageBy(string storageId) {
            StorageDTO storageDetail = null;

            int id = Convert.ToInt32(storageId);

            IEnumerable<StorageDTO> storageDetails = null;

            storageDetails = Enumerable.Range(1, 3).Select(index => new StorageDTO
            {
                StorageId = index,
                StorageDate = DateTime.Now.AddDays(index),
                StorageStatus = index,
                StorageAmount = index
            })
            .ToArray();

            storageDetail = storageDetails.FirstOrDefault(d => d.StorageId == id); //.Where(d => d.StorageId == id);

            return storageDetail;
        }

    }
}