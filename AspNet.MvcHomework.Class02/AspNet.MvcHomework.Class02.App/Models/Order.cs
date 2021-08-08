using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.MvcHomework.Class02.App.Models
{
    public class Order
    {
        public string PizzaName { get; set; }
        public string Address { get; set; }
    }
}
