using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project.Models;
using project.ViewModel;

namespace project.Controllers
{
    public class adminController : Controller
    {
        public projectprtEntities5 dbContex = new projectprtEntities5();
        // GET: admin
        [HttpGet]
        public ActionResult Add()
        {
            course un = new course();
            return View(un);
        }
        [HttpPost]
        public ActionResult Add(course couseModel)
        {
            dbContex.courses.Add(couseModel);
            dbContex.SaveChanges();
            ModelState.Clear();
            ViewBag.Success = "Successfully Added";
            return View("Add", new course());
        }
        public ActionResult Semi()
        {
            semester si = new semester();
            return View(si);
        }
        [HttpPost]
        public ActionResult Semi(semester SemesterModel)
        {
            dbContex.semesters.Add(SemesterModel);
            dbContex.SaveChanges();
            ModelState.Clear();
            ViewBag.Success = "Successfully Added";
            return View("Semi", new semester());
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(login2 login)
        {
            if (login.Admin_Id == "sajib" && login.password == "1234")
            {
                Session["admin"] = login.Admin_Id;
                return View("AdminDash");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult logout()
        {
            Session["admin"] = null;
            return View("login");
        }
        [HttpGet]
        public ActionResult Result()
        {
            var course = dbContex.courses.ToList();
            var student = dbContex.Students.ToList();
            var takenView = new TakeView
            {
                Courses = course,
                students = student
            };
            return View(takenView);
        }
        [HttpPost]
        public ActionResult Result(taken_courses take)
        {
            dbContex.taken_courses.Add(take);
            dbContex.SaveChanges();
            return View("Result", "ViewTaken", new taken_courses());
        }
        public ActionResult btn(button bt)
        {
            return View();
        }
        public ActionResult AdminDash()
        {
            return View();
        }
        public ActionResult Select()
        {
            return View();
        }
        public ActionResult Show_students()
        {
            return View();
        }
    }
}