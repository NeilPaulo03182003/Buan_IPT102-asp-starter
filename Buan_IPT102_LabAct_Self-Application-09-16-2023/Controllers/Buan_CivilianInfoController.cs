using Buan_IPT102_LabAct_Self_Application_09_16_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics; 

namespace Buan_IPT102_LabAct_Self_Application_09_16_2023.Controllers
{
    public class Buan_CivilianInfoController : Controller
    {
        // GET: Buan_CivilianInfoController
        // Speculations: Only 1 controller is allowed?
        private readonly ILogger<Buan_CivilianInfoController> _logger;

        public Buan_CivilianInfoController(ILogger<Buan_CivilianInfoController> logger)
        {
            _logger = logger;
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



        //// GET: Buan_CivilianInfoController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Buan_CivilianInfoController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Buan_CivilianInfoController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Buan_CivilianInfoController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Buan_CivilianInfoController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Buan_CivilianInfoController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Buan_CivilianInfoController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

      

    }
}
