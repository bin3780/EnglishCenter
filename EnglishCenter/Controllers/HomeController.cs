using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnglishCenter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Course()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult tuition()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Route()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}