using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChineseBudFood.Controllers
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

        public ActionResult OrderCart()
        {
            ViewBag.Message = "Your OrderList Page";
            return View();
        }

        public ActionResult Pay()
        {
            ViewBag.Message = "Your Pay Page";
            return View();
        }

    }
}