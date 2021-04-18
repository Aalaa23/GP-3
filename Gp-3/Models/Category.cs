using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
