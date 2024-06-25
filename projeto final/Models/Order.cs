using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public List<int>? ProductIds { get; set; }
        public DateTime OrderDate { get; set; }
        public required string CustomerName { get; set; }
        public object? Name { get; internal set; }
        public object? OrderName { get; internal set; }

        internal object PrintToExportDelimited()
        {
            throw new NotImplementedException();
        }

    }
}