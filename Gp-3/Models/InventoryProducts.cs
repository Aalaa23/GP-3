using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class InventoryProducts
    {
        public int InventoryProductsID { get; set; }
        public int InventoryID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public Inventory Inventory  { get; set; }
    }
}
