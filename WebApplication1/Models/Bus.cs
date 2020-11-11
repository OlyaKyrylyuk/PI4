﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Bus
    {
        
            
            public int Id { get; set; }
            public string Number { get; set; }
            public string Brand { get; set; }
            public string Color { get; set; }
            public DateTime Data { get; set; }
            public string Start { get; set; }
            public string End { get; set; }
            public double Price { get; set; }
            public ICollection<Buy_tickets> Buys_ticks { get; set; }
            public Bus()
            {
                Buys_ticks = new List<Buy_tickets>();
            }




    }
}