using Microsoft.EntityFrameworkCore;
using NewWorkPlaceDomain.CategoryJob;
using NewWorkPlaceDomain.Roles;


namespace NewWorkPlaceInfrastructure
{
    public class NewWorkPlaceDbContext : DbContext
    {
        public NewWorkPlaceDbContext(DbContextOptions<NewWorkPlaceDbContext> options) : base(options) { }
        
        public DbSet<CategoryJob> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }
      

    }
}
