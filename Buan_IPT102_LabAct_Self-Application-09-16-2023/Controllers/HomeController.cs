using Buan_IPT102_LabAct_Self_Application_09_16_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Buan_IPT102_LabAct_Self_Application_09_16_2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CivilianTablePage()
        {
            var CivilianInfoValu = new[]
            {
               new Buan_CivilianInfoModel {LastName = "Buan", FirstName = "Neil", MiddleName = "Cabanatan", HomeAddress = "32 Mahabang Layon", PhoneNumber = "09208619940"},
                new Buan_CivilianInfoModel {LastName = "Javate", FirstName = "Ruzzel", MiddleName = "Maneja", HomeAddress = "Kimco Villg.", PhoneNumber = "09108623940"},
                new Buan_CivilianInfoModel {LastName = "Buan", FirstName = "Angela", MiddleName = "Cabanatan", HomeAddress = "32 Mahabang Layon", PhoneNumber = "09304619230"},
                new Buan_CivilianInfoModel {LastName = "Buan", FirstName = "Jose Luis", MiddleName = "Cabanatan", HomeAddress = "32 Mahabang Layon", PhoneNumber = "N/A"},
            };

            return View(CivilianInfoValu);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}