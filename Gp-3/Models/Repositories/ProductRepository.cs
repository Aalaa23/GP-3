using Gp_3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class ProductRepository : IShoppingRepository<Product>
    {
        ShoppingDbContext db;
        public ProductRepository(ShoppingDbContext _db)
        {
            db = _db;
        }
        public void Add(Product Entity)
        {
            db.Products.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = Find(id);
            db.Products.Remove(product);
            Commit();
        }

        public Product Find(int id)
        {
            var product= db.Products.SingleOrDefault(a => a.ProductID == id);
            return product;
           
        }

        public IList<Product> List()
        {
            return db.Products.ToList();
        }

        public void Update(Product Entity)
        {
            db.Update(Entity);
            Commit();
        }
    }
}
