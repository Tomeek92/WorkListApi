using Microsoft.AspNetCore.Mvc;
using NewWorkPlaceDomain.Entities.ToFindJob.Register;
using NewWorkPlaceDomain.Interface;

namespace NewWorkPlace.Controllers
{
    public class RegisterToFindJobController : Controller
    {
        private readonly IRegisterToFindJob _db;
        public RegisterToFindJobController(IRegisterToFindJob dbContext)
        {
            _db = dbContext;
        }
        [HttpPost]
        public async Task<IActionResult> AddAcount(RegisterToFindJob registerToFindJob)
        {
           await _db.AddAcount(registerToFindJob);
            return View(registerToFindJob);
        }
        public IActionResult AddAcount()
        {
            return View();
        }
    }
}
