using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollageManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.CollegeName = "Super Admin";
            ViewBag.Title = "GPNC Supper Account";
            return RedirectToAction("Login", "Account");
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Routing() // Routing
        {
            return View();
        }

    }
}