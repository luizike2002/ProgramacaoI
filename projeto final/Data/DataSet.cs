using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Models;

namespace FoodApp.Data
{
    public class DataSet
    {
        public static List<Order> Orders { get; set; }
            = new List<Order>();
        public static List<Customer> Customers { get; set; } 
            = new List<Customer>();
    }
}