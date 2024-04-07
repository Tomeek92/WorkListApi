using NewWorkPlaceDomain.Entities.ToTakeJob.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceDomain.Interface
{
    public interface IRegisterToTakeJob
    {
        Task AddAccount(RegisterToTakeJob register);
    }
}
