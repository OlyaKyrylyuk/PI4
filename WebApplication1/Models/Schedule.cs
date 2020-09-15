using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public double Price { get; set; }
        public int Bus_id { get; set; }
    }
}