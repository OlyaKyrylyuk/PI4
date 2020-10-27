using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
      
        BusContext db = new BusContext();
   
        public ActionResult Index()
        {
            
            IEnumerable <Bus> bus = db.Buses;
           
            ViewBag.Bus = bus;
        
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpGet]
        public ActionResult BuyPost()
        {

           
            return View();
        }
        [HttpGet]
        public ActionResult Orders()
        {
            IEnumerable<Buy_tickets> tickets = db.Buy_tickets;
            ViewBag.Tickets = tickets;
  
            return View();
        }
        [HttpPost]
        public ActionResult BuyPost(Buy_tickets tickets)
        {

            db.Buy_tickets.Add(tickets);
          
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            IEnumerable<Bus> bus = db.Buses;
            
            ViewBag.Bus = bus;
            return View();
        }

        [HttpPost]
        public ActionResult AddPost(Bus bus)
        {

            db.Buses.Add(bus);
            
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult EditBus(int id)
        {
            Bus bus = db.Buses.Find(id);
            ViewBag.Bus = bus;
            return View();
        }
        [HttpPost]
        public ActionResult EditBus(Bus bus, int id)
        {
            Bus old_bus = db.Buses.FirstOrDefault(p => p.Id == bus.Id);
            old_bus.Number = bus.Number;
            old_bus.Brand = bus.Brand;
            old_bus.Color = bus.Color;
            old_bus.Data = bus.Data;
            old_bus.Start = bus.Start;
            old_bus.End = bus.End;
            old_bus.Price = bus.Price;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteBus(int id)
        {
            Bus bus = db.Buses.FirstOrDefault(p => p.Id == id); 
            db.Buses.Remove(bus);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteOrder(int id)
        {
            Buy_tickets order = db.Buy_tickets.FirstOrDefault(p => p.Id == id);
            db.Buy_tickets.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}