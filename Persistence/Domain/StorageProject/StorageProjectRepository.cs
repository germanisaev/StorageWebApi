using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ExamWebApi.Models.Storages;
using ExamWebApi.Persistence.Domain.StorageProject;

namespace ExamWebApi.Persistence.Domain.StorageProject {
    public class StorageProjectRepository: IStorageProjectRepository {


        private readonly StorageProjectContext _context;
        public StorageProjectRepository(StorageProjectContext context) {//: base(connection, transaction) {
            _context = context;
        }

        public async Task<IEnumerable<StorageDTO>> GetAllStorages() {
            return _context.Storages;
        }

        public async Task<StorageDTO> GetStorageBy(string storageId) {
            return _context.Storages.Find(storageId);
        }

    }
}
