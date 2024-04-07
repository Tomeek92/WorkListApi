using NewWorkPlaceDomain.Entities.ToFindJob.Register;
using NewWorkPlaceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceApplication.Services
{
    public class RegisterToFindJobServices
    {
        private readonly IRegisterToFindJob _db;
        public RegisterToFindJobServices(IRegisterToFindJob registerToFindJob)
        {
            _db = registerToFindJob;
        }
        public async Task AddAccount(RegisterToFindJob register)
        {
           await _db.AddAcount(register);
            
        }
    }
}
