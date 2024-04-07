using NewWorkPlaceDomain.Entities.ToTakeJob.Register;
using NewWorkPlaceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceInfrastructure.Repository
{
    public class RegisterToTakeJobRepository : IRegisterToTakeJob
    {
        private readonly NewWorkPlaceDbContext _db;
        public RegisterToTakeJobRepository(NewWorkPlaceDbContext dbContext)
        {
            _db = dbContext;   
        }
        public async Task AddAccount(RegisterToTakeJob register)
        {
           _db.Add(register);
            await _db.SaveChangesAsync();
        }
    }
}
