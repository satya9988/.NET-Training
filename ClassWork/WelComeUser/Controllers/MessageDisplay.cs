using Microsoft.AspNetCore.Mvc;

namespace WelComeUser.Controllers
{
    public class MessageDisplay : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayName(string Name)
        {
            ViewBag.Name = Name;
            return View();
        }

        }
    }
