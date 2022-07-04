using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_4_Task_1.Models;

namespace Lab_4_Task_1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Student student)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Submit");
            }

            return View(student);
        }

        public ActionResult Submit(Student student)
        {
            return View(student);
        }
    }
}