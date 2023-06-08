using ExamWebApi.Models.Storages;
using Microsoft.EntityFrameworkCore;

namespace ExamWebApi.Persistence.Domain.StorageProject {

    public class StorageProjectContext: DbContext {

        public StorageProjectContext(DbContextOptions<StorageProjectContext> options): base(options) {}

        public virtual DbSet<StorageDTO> Storages { get; set; }
        public virtual DbSet<StatusDTO> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StorageDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            BuildStorageNames(modelBuilder);
            BuildStatusNames(modelBuilder);
        }

        private void BuildStorageNames(ModelBuilder modelBuilder) {
            //modelBuilder.Entity<StorageDTO>().HasKey(e => new { e.StorageId });
            modelBuilder.Entity<StorageDTO>().HasData(new StorageDTO[] {
                new StorageDTO{ StorageId = 1, StorageDate = System.DateTime.Now, StorageStatus = 1, StorageAmount = 4 },
                new StorageDTO{ StorageId = 2, StorageDate = System.DateTime.Now, StorageStatus = 2, StorageAmount = 3 },
                new StorageDTO{ StorageId = 3, StorageDate = System.DateTime.Now, StorageStatus = 3, StorageAmount = 2 },
                new StorageDTO{ StorageId = 4, StorageDate = System.DateTime.Now, StorageStatus = 2, StorageAmount = 1 },
            });
        }

        private void BuildStatusNames(ModelBuilder modelBuilder) {
            //modelBuilder.Entity<StorageDTO>().HasKey(e => new { e.StorageId });
            modelBuilder.Entity<StatusDTO>().HasData(new StatusDTO[] {
                new StatusDTO{ Key = 1, Value = "Active" },
                new StatusDTO{ Key = 2, Value = "Completed" },
                new StatusDTO{ Key = 3, Value = "Cancelled" },
                new StatusDTO{ Key = 4, Value = "Blocked" },
            });
        }
    }

}
