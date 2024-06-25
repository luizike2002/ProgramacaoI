using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }

        internal object PrintToExportDelimited()
        {
            throw new NotImplementedException();
        }

    }
}