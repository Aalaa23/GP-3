using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class WishList
    {
        public int WishListID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public ICollection<WishListProducts> WishListProducts { get; set; }
    }
}
