using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int SellerID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public float Price { get; set; }
        public string Img { get; set; }
        public int AmountInStock { get; set; }
        public int EntryDate { get; set; }
        public float Rate { get; set; }

        public Seller Seller { get; set; }
        public Category Category { get; set; }

    }
}
