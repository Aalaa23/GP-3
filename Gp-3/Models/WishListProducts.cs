using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class WishListProducts
    {
        public int WishListProductsID { get; set; }
        public int WishListID { get; set; }
        public WishList WishList { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
