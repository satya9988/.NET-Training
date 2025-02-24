using Microsoft.AspNetCore.Mvc;
using RentCalculation.Models;

namespace RentCalculation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Claculate(Customer c)
        {
            if (ModelState.IsValid)
            {
                TimeSpan t = c.EndDate - c.StartDate;

                int n = t.Days;
                c.TotatCost = c.cost * n;
                if (c.TotatCost > 0)
                {
                    return View(c);
                }
                else
                {   

                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
        }
    }
}