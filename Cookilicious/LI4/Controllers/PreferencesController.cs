using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LI4.Controllers
{
    public class PreferencesController : Controller
    {
        // GET: Preferences
        public ActionResult PrefCategories()
        {
            return View();
        }

        public ActionResult PrefUtensils()
        {
            return View();
        }

        public ActionResult PrefIngredients()
        {
            return View();
        }
    }
}