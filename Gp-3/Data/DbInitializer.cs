using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gp_3.Models;

namespace Gp_3.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShoppingDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
