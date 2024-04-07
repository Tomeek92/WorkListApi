using NewWorkPlaceDomain.Entities.ToFindJob.Register;
using NewWorkPlaceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceInfrastructure.Repository
{
    public class RegisterToFindJobRepository : IRegisterToFindJob
    {
        private readonly NewWorkPlaceDbContext _db;
        public RegisterToFindJobRepository(NewWorkPlaceDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task AddAcount(RegisterToFindJob register)
        {
            _db.Add(register);
            await _db.SaveChangesAsync();
        }
    }
}
