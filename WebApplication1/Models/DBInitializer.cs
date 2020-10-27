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
                Data = new DateTime(2020, 6, 10),
                Start = "Хмельницький",
                End = "Вінниця",
                Price = 130
            });
         
            db.Buses.Add(new Bus
            {
                Number = "ET4043IK",
                Brand = "NISSAN",
                Color = "Black",
                Data = new DateTime(2020, 11, 11),
                Start = "Хмельницький",
                End = "Київ",
                Price = 260
            });
            db.Buses.Add(new Bus
            {
                Number = "IK6832WE",
                Brand = "MERCEDES",
                Color = "Gold",
                Data = new DateTime(2020, 10, 10),
                Start = "Хмельницький",
                End = "Львів",
                Price = 200
            });
            db.SaveChanges();
            base.Seed(db);
        }
    }
}
