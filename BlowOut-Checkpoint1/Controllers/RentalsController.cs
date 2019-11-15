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
        public static List<Rentals> lstRentals = new List<Rentals>()
        {
            new Rentals{ InstrumentCode = 1, InstrumentName = "Trumpet", NewPrice = "$55 a month", UsedPrice = "$25 a month"},
            new Rentals{ InstrumentCode = 2, InstrumentName = "Trombone", NewPrice = "$60 a month", UsedPrice = "$35 a month"},
            new Rentals{ InstrumentCode = 3, InstrumentName = "Tuba", NewPrice = "$70 a month", UsedPrice = "$50 a month"},
            new Rentals{ InstrumentCode = 4, InstrumentName = "Flute", NewPrice = "$40 a month", UsedPrice = "$25 a month"},
            new Rentals{ InstrumentCode = 5, InstrumentName = "Clarinet", NewPrice = "$35 a month", UsedPrice = "$27 a month"},
            new Rentals{ InstrumentCode = 6, InstrumentName = "Saxophone", NewPrice = "$42 a month", UsedPrice = "$30 a month"},
        };

        // GET: Rentals
        public ActionResult Index()
        {
            return View(lstRentals);
        }

        public ActionResult CheckPrices(int iCode)
        {
            Rentals oInstrument = lstRentals.Find(x => x.InstrumentCode == iCode);

            ViewBag.InstrumentName = oInstrument.InstrumentName;
            ViewBag.Used = "";
            ViewBag.New = "";


            return View(lstRentals);
        }

        public ActionResult UsedPrice(string sName)
        {
            Rentals oInstrument = lstRentals.Find(x => x.InstrumentName == sName);

            ViewBag.InstrumentName = oInstrument.InstrumentName;
            ViewBag.Used = oInstrument.UsedPrice;
            ViewBag.New = "";

            return View("CheckPrices");
        }

        public ActionResult NewPrice(string sName)
        {
            Rentals oInstrument = lstRentals.Find(x => x.InstrumentName == sName);

            ViewBag.InstrumentName = oInstrument.InstrumentName;
            ViewBag.Used = "";
            ViewBag.New = oInstrument.NewPrice;

            return View("CheckPrices");
        }
    }
}