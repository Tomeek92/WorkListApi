using NewWorkPlaceDomain.Entities.ToTakeJob.Register;
using NewWorkPlaceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceApplication.Services
{
    public class RegisterToTakeJobServices 
    {
        private readonly IRegisterToTakeJob _db;
        public RegisterToTakeJobServices(IRegisterToTakeJob registerAccount)
        {
            _db = registerAccount;
        }
        public async Task AddAccount(RegisterToTakeJob register)
        {
          await _db.AddAccount(register);
        }
    }
}
