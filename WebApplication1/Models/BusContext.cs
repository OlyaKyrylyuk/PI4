
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
   
    public class BusContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Buy_tickets> Buy_tickets { get; set; }
    }
}