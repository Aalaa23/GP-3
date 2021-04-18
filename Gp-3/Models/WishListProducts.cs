using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class WishListProducts
    {
        public int ID { get; set; }
        public int WishListID { get; set; }
        public int ProductID { get; set; }
        public ICollection<WishList> WishList { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
