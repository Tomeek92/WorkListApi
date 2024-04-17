using Microsoft.EntityFrameworkCore;
using NewWorkPlaceDomain.Entities.CategoryJob;
using NewWorkPlaceDomain.Entities.ListOfWork;
using NewWorkPlaceDomain.Entities.Roles;
using NewWorkPlaceDomain.Entities.ToFindJob.Register;
using NewWorkPlaceDomain.Entities.ToTakeJob.Register;

namespace NewWorkPlaceInfrastructure
{
    public class NewWorkPlaceDbContext : DbContext
    {
        public NewWorkPlaceDbContext(DbContextOptions<NewWorkPlaceDbContext> options) : base(options) { }
        
        public DbSet<CategoryJob> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RegisterToFindJob> RegisterToFindJobs { get; set;} 
        public DbSet<RegisterToTakeJob> RegisterToTakeJobs { get; set;} 
        public DbSet <ListOfWorkToFindJob> ListOfWorkToFindJobs { get; set;}
      

    }
}
