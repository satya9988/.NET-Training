using HallBudgetPro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HallBudgetPro.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHallDAO _hallDAO;

        public HomeController(IHallDAO hallDAO)
        {
            _hallDAO = hallDAO;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(int price)
        {
            List<Hall> halls = _hallDAO.GetHallDetails(price);

            if (halls.Count == 0)
            {
                ViewBag.Message = "No halls found within the budget!!!";
            }

            return View(halls);
        }
    }
}
