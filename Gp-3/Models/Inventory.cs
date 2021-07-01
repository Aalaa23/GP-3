using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int SellerID { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string BuildingNO { get; set; }
        public Seller Seller { get; set; }
        public ICollection<InventoryProducts> InventoryProducts { get; set; }
    }
}
