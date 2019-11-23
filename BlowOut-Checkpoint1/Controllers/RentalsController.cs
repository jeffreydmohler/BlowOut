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

        //returns basic page when you click on instruments
        public ActionResult CheckPrices(string InstrumentName)
        {
            List<int> lstInst = new List<int>();
            //finds rental object on instrument code
            //Instruments oInstrument = lstRentals.Find(x => x.InstrumentCode == iCode);

            foreach (var item in db.instruments.ToList())
            {
                if (InstrumentName == item.InstrumentName)
                {
                    lstInst.Add(item.InstrumentCode);
                }
            }

            //loads up viewbag for each item wanted
            Instruments oInstrument1 = db.instruments.Find(lstInst[0]);
            ViewBag.Instrument1 = oInstrument1;

            Instruments oInstrument2 = db.instruments.Find(lstInst[1]);
            ViewBag.Instrument2 = oInstrument2;

            /*for (var iCount = 0; iCount < lstInst.Count; iCount++)
            {
                string sInstrument = "oInstrument" + iCount;
                Instruments sInstrument = db.instruments.Find(lstInst[iCount]);
                ViewBag.Instrument1 = oInstrument1;
            }*/

            return View();
        }
/*
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