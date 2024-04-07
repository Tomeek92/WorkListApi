using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WorkListApi.Models;

namespace WorkListApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
