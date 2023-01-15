using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}