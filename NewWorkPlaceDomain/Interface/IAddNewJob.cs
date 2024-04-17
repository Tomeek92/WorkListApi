using NewWorkPlaceDomain.Entities.ListOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceDomain.Interface
{
    public interface IAddNewJob
    {
        Task AddJob (ListOfWorkToFindJob job);
        Task<List<ListOfWorkToFindJob>> ListJobs (ListOfWorkToFindJob jobs);
    }
}
