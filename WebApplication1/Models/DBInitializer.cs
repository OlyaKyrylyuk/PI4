using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<BusContext>
    {
        protected override void Seed(BusContext db)
        {
            db.Buses.Add(new Bus
            {
                Number = "GK5464FG",
                Brand = "Opel",
                Color = "White",
            });
         
            db.Buses.Add(new Bus
            {
                Number = "ET4043IK",
                Brand = "NISSAN",
                Color = "Black",
            });
            db.Buses.Add(new Bus
            {
                Number = "IK6832WE",
                Brand = "MERCEDES",
                Color = "Gold",
            });
            db.SaveChanges();
            base.Seed(db);
        }
    }
}
