using Gp_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.ViewModel
{
    public class AddProductViewModel
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int SellerID { get; set; }
        public int InventoryID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public float Price { get; set; }
        public string Img { get; set; }
        public int AmountInStock { get; set; }
        public float Rate { get; set; }
        public List<Category> Categories { get; set; }
        public List<Inventory> Inventories { get; set; }
    }
}
