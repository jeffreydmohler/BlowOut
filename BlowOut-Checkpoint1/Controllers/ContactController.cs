using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace BlowOut_Checkpoint1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Error = "Please call Support at " + "<strong>" + "<u>" + "801-555-1212" + "</u>" + "</strong>" + ". Thank you!";
            
            return View();
        }
     
        public ActionResult Email(string name, string email)
        {
            string sName = name;
            string sEmail = email;

            ViewBag.Message = "Thank you " + sName + ". We will send an email to " + sEmail;

            MailMessage mailMessage = new MailMessage(sEmail, sEmail);
            mailMessage.Subject = "This is a test!";
            mailMessage.Body = "You wonderful man!";

            SmtpClient smptClient = new SmtpClient("smtp.gmail.com", 587);
            smptClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "Calen934test@gmail.com",
                Password = "TestingIsFun"
            };
            smptClient.EnableSsl = true;
            smptClient.Send(mailMessage);
            return View();
        }
    }
}