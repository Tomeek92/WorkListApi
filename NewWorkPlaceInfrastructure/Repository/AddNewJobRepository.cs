using Microsoft.EntityFrameworkCore;
using NewWorkPlaceDomain.Entities.ListOfWork;
using NewWorkPlaceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceInfrastructure.Repository
{
    public class AddNewJobRepository : IAddNewJob
    {
        private readonly NewWorkPlaceDbContext _dbContext;
        public AddNewJobRepository(NewWorkPlaceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddJob(ListOfWorkToFindJob job)
        {
            _dbContext.Add(job); 
            await _dbContext.SaveChangesAsync();   

        }

        public async Task<List<ListOfWorkToFindJob>> ListJobs(ListOfWorkToFindJob job)
        {
          return await _dbContext.ListOfWorkToFindJobs.ToListAsync();
            
        }
    }
}
