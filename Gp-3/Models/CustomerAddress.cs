using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class CustomerAddress
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string DetailedAddress { get; set; }
        public Customer Customer { get; set; }

    }
}
