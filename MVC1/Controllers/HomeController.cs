using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        ChairContext db = new ChairContext();
        public ActionResult Index()
        {
            return View(db.Chairs);
        }

        public ActionResult GetName()
        {
            string[] names = new string[] { "Стул простой", "Стул не простой"};
            return View(names);
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
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.ChairId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо, " + purchase.Person + " за покупку!";
        }
        public string SumDegree(double a, double b)
        {
            double s = a * a + b * b;
            return "<h2>Сумма квадратов " + a +" и " + b + " равна " + s + "</h2>";
        }
        public FileResult GetFile()
        {
            string file_path = Server.MapPath("~/Files/All.xlsx");
            // Тип файла - content-type string
            string file_type = "application/xlsx";
            // Имя файла - необязательно
            string file_name = "All.xlsx";
            return File(file_path, file_type, file_name);
        }
    }
}