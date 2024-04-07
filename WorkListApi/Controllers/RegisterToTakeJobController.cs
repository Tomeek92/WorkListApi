using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NewWorkPlaceDomain.Entities.ToTakeJob.Register;
using NewWorkPlaceDomain.Interface;

namespace NewWorkPlace.Controllers
{
    public class RegisterToTakeJobController : Controller
    {
        private readonly IRegisterToTakeJob _db;
        public RegisterToTakeJobController(IRegisterToTakeJob register)
        {
            _db = register;
        }
        [HttpPost]
        public async Task<IActionResult> AddAccount(RegisterToTakeJob registerToTakeJob)
        {
           await _db.AddAccount(registerToTakeJob);
            return View(registerToTakeJob);   
        }
        public IActionResult AddAccount()
        {
            return View();
        }
    }
}
