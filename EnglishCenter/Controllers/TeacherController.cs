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
////#todo :Quản lý lớp học >> check user nào có cùng id class thì cho vào 1 list học viên của lớp!!
///#todo : input điểm từng cá nhân > đánh giá điểm F > A+ trong quản lý khoá học
///
    }
}