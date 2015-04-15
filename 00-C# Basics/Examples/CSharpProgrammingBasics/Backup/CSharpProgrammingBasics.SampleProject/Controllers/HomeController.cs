using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpProgrammingBasics.SampleProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to C# Programming Basics-Samples!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
