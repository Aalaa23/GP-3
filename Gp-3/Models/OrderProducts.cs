using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class OrderProducts
    {
        public int OrderProductsID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }
        public float PriceEach { get; set; }
        public float Total { get; set; }

    }
}
