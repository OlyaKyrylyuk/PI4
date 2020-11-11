using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Buy_tickets
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int N_card { get; set; }
        public string Address { get; set; }
        public int? BusId { get; set; }
        public Bus Bus { get; set; }
    }
}