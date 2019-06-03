using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LI4.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult MainPage()
        {
            return View();
        }

        public ActionResult Recipe()
        {
            return View();
        }

        public ActionResult MultiRecipes()
        {
            return View();
        }

        public ActionResult Step()
        {
            return View();
        }
        public ActionResult AfterFinalStep()
        {
            return View();
        }
        public ActionResult Help()
        {
            return View();
        }
    }
}