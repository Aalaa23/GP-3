using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class OrderDetails
    {
        public int OrderDetailsID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int Discount { get; set; }
        public int TotalPrice { get; set; }
    }
}
