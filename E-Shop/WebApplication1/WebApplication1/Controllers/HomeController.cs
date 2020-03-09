using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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
        public ActionResult News()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Detail1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Detail2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Detail3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Menu()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}