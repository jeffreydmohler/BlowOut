using BlowOut_Checkpoint1.DAL;
using BlowOut_Checkpoint1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut_Checkpoint1.Controllers
{
    public class RentalsController : Controller
    {
        private BlowOutContext db = new BlowOutContext();

        //list of all rental items using rentals class
        /*public static List<Instruments> lstRentals = new List<Instruments>()
        {
            new Instruments{ InstrumentCode = 1, InstrumentName = "Trumpet", Price = 55},
            new Instruments{ InstrumentCode = 2, InstrumentName = "Trombone", Price = 60},
            new Instruments{ InstrumentCode = 3, InstrumentName = "Tuba", Price = 70},
            new Instruments{ InstrumentCode = 4, InstrumentName = "Flute", Price = 40},
            new Instruments{ InstrumentCode = 5, InstrumentName = "Clarinet", Price = 35},
            new Instruments{ InstrumentCode = 6, InstrumentName = "Saxophone", Price = 42},
        };*/

        // GET: Rentals
        public ActionResult Index()
        {
            //return View(lstRentals);
            return View(db.instruments.ToList());
        }
/*
        //returns basic page when you click on instruments
        public ActionResult CheckPrices(int iCode)
        {
            //finds rental object on instrument code
            //Instruments oInstrument = lstRentals.Find(x => x.InstrumentCode == iCode);
            Instruments oInstrument = db.instruments.Find(x => x.InstrumentCode == iCode);

            //loads up viewbag for each item wanted
            ViewBag.InstrumentName = oInstrument.InstrumentName;
            ViewBag.Used = "";
            ViewBag.New = "";

            return View(lstRentals);
        }

        public ActionResult UsedPrice(string sName)
        {
            Instruments oInstrument = lstRentals.Find(x => x.InstrumentName == sName);

            //shows the used price
            ViewBag.InstrumentName = oInstrument.InstrumentName;
            //ViewBag.Used = oInstrument.UsedPrice;
            ViewBag.New = "";

            return View("CheckPrices");
        }

        public ActionResult NewPrice(string sName)
        {
            Instruments oInstrument = lstRentals.Find(x => x.InstrumentName == sName);

            //shows the new price
            ViewBag.InstrumentName = oInstrument.InstrumentName;
            ViewBag.Used = "";
            //ViewBag.New = oInstrument.NewPrice;

            return View("CheckPrices");
        }*/
    }
}