using Gp_3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class CategoryRepository : IShoppingRepository<Category>
    {
        ShoppingDbContext db;

        public CategoryRepository(ShoppingDbContext _db)
        {
            db = _db;
        }

      

        public void Add(Category Entity)
        {
            db.Categories.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = Find(id);
            db.Categories.Remove(category);
            Commit();
        }

        public Category Find(int id)
        {
            var category = db.Categories.SingleOrDefault(a => a.CategoryID == id);
            return category;
        }

        public IList<Category> List()
        {
            return db.Categories.ToList();
        }

        public void Update(Category Entity)
        {
            db.Update(Entity);
            Commit();
        }

        
    }
}
