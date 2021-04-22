using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class Customer
    {
        
        public int CustomerID { get; set; }
        public int WishListID { get; set; }
        public WishList WishList { get; set; }
        public int CartID { get; set; }
        public Cart Cart { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<CustomerAddress> Addresses { get; set; }
       
        public ICollection<Order> Orders { get; set; }
    }
}
