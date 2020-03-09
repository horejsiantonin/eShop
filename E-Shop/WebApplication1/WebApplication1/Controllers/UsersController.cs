using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    { 
        // GET: Users
        public ActionResult Index(int id = 5)
        {
            int count = id;

            // db
            List<Person> data = new List<Person>() {
                //new Person() { Name = "Pepa", Surname = "Novak", Age = 50 },
                //new Person() { Name = "Karel", Surname = "Kral", Age = 15 },
                //new Person() { Name = "Viktor", Surname = "LUsk", Age = 30 }
            };

            for (int i = 0; i < count; i++)
            {
                data.Add(new Person() { Name = "Pepa", Surname = "Novak", Age = 50 });
            }

            this.ViewBag.Data = data;

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            Person person = new Person() { Name = "Pepa", Surname = "Novak", Age = 50 };

            return View(person);
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (!this.ModelState.IsValid)
                return View(person);

            // save to db


            return RedirectToAction("Index", "Users");
        }
    }
}