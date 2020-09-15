using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        BusContext db = new BusContext();
   
        public ActionResult Index()
        {
            // Отримуємо з БД всі об'єкти
            IEnumerable <Bus> bus = db.Buses;
            // Передаємо всі об'єкти в динамічну властивість  в ViewBag
            ViewBag.Bus = bus;
         // Повертаємо представлення
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BusId = id;
            return View();
        }

    }
}