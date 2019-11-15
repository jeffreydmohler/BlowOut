//Name: Jeffrey Mohler, Natalie Jacobsen, Eric Louis, Calen Johnson
//Description: This website is a instrument rentals page that allows the user to see available instrument and prices. It also sends emails to specified users.
//Date: November 15, 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut_Checkpoint1.Controllers
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
    }
}