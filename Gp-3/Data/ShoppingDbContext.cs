using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gp_3.Data
{
    public class ShoppingDbContext : IdentityDbContext
    {
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options)
            : base(options)
        {
            
        }
    }
}
