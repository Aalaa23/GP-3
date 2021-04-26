using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int CustomerID { get; set; }

        public Customer Customer { get; set; }
        public int TotalPrice { get; set; }
        public ICollection<CartProducts> CartProducts { get; set; }
    }
}
