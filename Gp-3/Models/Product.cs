using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int SellerID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public float Price { get; set; }
        public string Img { get; set; }
        public int AmountInStock { get; set; }
        public float Rate { get; set; }

        public Seller Seller { get; set; }
        public Category Category { get; set; }
        public ICollection<WishListProducts> WishListProducts { get; set; }
        public ICollection<CartProducts> CartProducts { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }

    }
}
