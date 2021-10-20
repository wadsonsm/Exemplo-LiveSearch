using LiveSearchDemoWithJQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveSearchDemoWithJQuery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            StudentInfoEntities db = new StudentInfoEntities();
            return View(db.StudentInfoes.ToList());
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
    }
}