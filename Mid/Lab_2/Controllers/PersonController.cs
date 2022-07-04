using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Lab_2.Models;

namespace Lab_2.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        new public ActionResult Profile()
        {
            Person person = new Person() {
                Id = "19-39517-1",
                Name = "Rahat, Md Mohibor Rahman",
                Dob = "27-08-1999"
            };

            return View(person);
        }
    }
}