using NewWorkPlaceDomain.Entities.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceInfrastructure.Seeders
{
    public class SeederRoles
    {
        private readonly NewWorkPlaceDbContext _db;
        public SeederRoles(NewWorkPlaceDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task Seed()
        {
            if(await _db.Database.CanConnectAsync())
            {
                if(!_db.Roles.Any())
                {
                    var newRole = new Role
                    {
                        Name = "EMPLOYEE",
                        Id = Guid.NewGuid()
                    };
                    _db.Roles.Add(newRole);
                    await _db.SaveChangesAsync();
                }
            }
           
        }
    }
}
