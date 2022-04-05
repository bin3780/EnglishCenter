using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnglishCenter.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult IndexTeacher()
        {
            return View();
        }
        public ActionResult GiaoAn()
        {
            return View();
        }
        public ActionResult QuanlyLopHoc()
        {
            return View();
        }
    }
}