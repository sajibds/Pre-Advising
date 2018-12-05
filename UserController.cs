using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project.Models;
using project.ViewModel;


namespace project.Controllers
{
    public class UserController : Controller
    {
        public projectprtEntities5 dbContex =new projectprtEntities5();
        // GET: User
        
        public ActionResult Regi()
        {
            Student um = new Student();
            return View(um);
        }
        

      [HttpGet]
        public ActionResult Result()
        {
            var course = dbContex.courses.ToList();
            var student = dbContex.Students.ToList();
            var takenView=new TakeView
            {
                Courses = course,
                students=student
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

        public ActionResult ViewTaken()
        {
            var taken = dbContex.taken_courses.ToList();
            return View(taken);
        }
        [HttpGet]
        public ActionResult Login(project.Models.Student stm)
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(login login)
        {

            var student = dbContex.Students.Where(s => s.student_id == login.student_Id).FirstOrDefault();
            if (student != null)
            {
                if (student.password == login.password)
                {
                    Session["student"] = student.student_id;
                    return View("StudentDash");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult logout()
        {
            Session["student"] = null;
            return View("login");
        }
        public ActionResult StudentDash()
        {
            var sem = dbContex.semesters.ToList();
            
            return View(sem);
        }


        [HttpGet]
        public ActionResult Register()
        {
            Student un = new Student();
            return View(un);
        }
        [HttpPost]
        public ActionResult Register(Student StudentModel)
        {
            dbContex.Students.Add(StudentModel);
            dbContex.SaveChanges();
            ModelState.Clear();
            ViewBag.Success = "Successfully Added";
            return View("Register", new Student());
        }
        public ActionResult ShowCourse()
        {
            return View();
        }
       
    }
}