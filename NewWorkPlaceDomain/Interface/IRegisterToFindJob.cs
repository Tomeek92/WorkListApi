using NewWorkPlaceDomain.Entities.ToFindJob.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceDomain.Interface
{
    public interface IRegisterToFindJob
    {
        Task AddAcount(RegisterToFindJob register);
    }
}
