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
        //list of all rental items using rentals class
        public static List<Instrument> lstRentals = new List<Instrument>()
        {
            new Instrument{ InstrumentCode = 1, InstrumentName = "Trumpet", Price = 55},
            new Instrument{ InstrumentCode = 2, InstrumentName = "Trombone", Price = 60},
            new Instrument{ InstrumentCode = 3, InstrumentName = "Tuba", Price = 70},
            new Instrument{ InstrumentCode = 4, InstrumentName = "Flute", Price = 40},
            new Instrument{ InstrumentCode = 5, InstrumentName = "Clarinet", Price = 35},
            new Instrument{ InstrumentCode = 6, InstrumentName = "Saxophone", Price = 42},
        };

        // GET: Rentals
        public ActionResult Index()
        {
            return View(lstRentals);
        }

        //returns basic page when you click on instruments
        public ActionResult CheckPrices(int iCode)
        {
            //finds rental object on instrument code
            Instrument oInstrument = lstRentals.Find(x => x.InstrumentCode == iCode);

            //loads up viewbag for each item wanted
            ViewBag.InstrumentName = oInstrument.InstrumentName;
            ViewBag.Used = "";
            ViewBag.New = "";

            return View(lstRentals);
        }

        public ActionResult UsedPrice(string sName)
        {
            Instrument oInstrument = lstRentals.Find(x => x.InstrumentName == sName);

            //shows the used price
            ViewBag.InstrumentName = oInstrument.InstrumentName;
            //ViewBag.Used = oInstrument.UsedPrice;
            ViewBag.New = "";

            return View("CheckPrices");
        }

        public ActionResult NewPrice(string sName)
        {
            Instrument oInstrument = lstRentals.Find(x => x.InstrumentName == sName);

            //shows the new price
            ViewBag.InstrumentName = oInstrument.InstrumentName;
            ViewBag.Used = "";
            //ViewBag.New = oInstrument.NewPrice;

            return View("CheckPrices");
        }
    }
}