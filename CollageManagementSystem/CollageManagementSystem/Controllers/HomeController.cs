using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CollageManagementSystem.Models;

namespace CollageManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        DAL dblayer = new DAL();

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

        public JsonResult userlogin(LoginViewModel us)
        {
            string result = Convert.ToString(dblayer.userlogin(us));

            if (result == "1")
            {
                Session["user"] = us.Email;
            }
            else
            {
                result = "Email or Password is wrong";

            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}