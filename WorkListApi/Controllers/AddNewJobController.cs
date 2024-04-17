using Microsoft.AspNetCore.Mvc;
using NewWorkPlaceDomain.Entities.ListOfWork;
using NewWorkPlaceDomain.Interface;

namespace NewWorkPlace.Controllers
{
    public class AddNewJobController : Controller
    {
        private readonly IAddNewJob _DbContext;
        public AddNewJobController(IAddNewJob dbContext)
        {
            _DbContext = dbContext;
        }
        [HttpPost]
        public async Task <IActionResult> AddNewJob(ListOfWorkToFindJob job)
        {
            await _DbContext.AddJob(job);
            return View(job);
        }
        [HttpGet]
        public async Task <IActionResult> GetJobsList(ListOfWorkToFindJob listsJob)
        {
            await _DbContext.ListJobs(listsJob);
            return View(listsJob); 
        }
    }
}
