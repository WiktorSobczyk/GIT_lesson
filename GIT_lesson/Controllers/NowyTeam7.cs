using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIT_lesson.Controllers
{
    public class NowyTeam7 : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "COś";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Inne informacje";

            return View();
        }
    }
}