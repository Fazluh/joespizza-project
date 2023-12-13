using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace joespizza.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }


        public string Type { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}