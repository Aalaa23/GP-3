using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class CartProducts
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
