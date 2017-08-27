using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemi.Data;

namespace YemiOyetoro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RestsharpTest b = new RestsharpTest();
          List<State> c =  b.getState("usa");
            return View(c);
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