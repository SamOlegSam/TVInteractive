using TV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.Entity;


namespace TV.Controllers
{
    public class HomeController : Controller
    {
        public PhoneEntities db = new PhoneEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Onewindow()
        {
            return View();
        }

        public ActionResult Grafik()
        {
            return View();
        }

        public ActionResult Procedure()
        {
            return View();
        }

        public ActionResult Documentation()
        {
            return View();
        }

        public ActionResult Concern()
        {
            return View();
        }

        public ActionResult Drujba()
        {
            return View();
        }

        public ActionResult Filial()
        {
            return View();
        }

        public ActionResult Zheleznodor()
        {
            return View();
        }

        public ActionResult Telline()
        {
            return View();
        }

        public ActionResult Phone()
        {
            
                        
            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult Video()
        {
            return View();
        }

        public ActionResult Vacancy()
        {
            return View();
        }

        public ActionResult Administration()
        {
            return View();
        }

        public ActionResult News()
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

        public ActionResult GetLastName(string str)
        {
            List<Phone> phoneList = new List<Phone>();
            phoneList = db.Phone.Where(p => p.FIO.Contains(str)||p.Doljnost.Contains(str)).ToList();
            ViewBag.phone = phoneList;
            return View(phoneList);
        }

        public ActionResult Loock()
        {
            
            return PartialView();
        }
    }
}