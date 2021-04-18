using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class OrderProduct
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Qty { get; set; }
        public float PriceEach { get; set; }
        public float Total { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
