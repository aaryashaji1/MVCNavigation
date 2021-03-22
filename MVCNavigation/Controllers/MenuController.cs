using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNavigation.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult LoginPage()
        {
            return View();
        }



    }
}