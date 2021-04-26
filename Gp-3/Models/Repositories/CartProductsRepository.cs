using Gp_3.Data; // constructor متنسوش تعملو السطر ده عشان تعرفو تستتعملو ال دي بى كونتكست فى ال  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class CartProductsRepository : IShoppingRepository<CartProducts>
    {
        ShoppingDbContext db;
        public CartProductsRepository(ShoppingDbContext _db)
        {
            db = _db;
        }
        public void Add(CartProducts Entity)
        {
            db.CartProducts.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var cartProduct = db.CartProducts.Find(id);
            db.CartProducts.Remove(cartProduct);
            Commit();
        }

        public CartProducts Find(int id)
        {
            var cartProduct = db.CartProducts.SingleOrDefault(a => a.CartProductsID == id);
            return cartProduct;
        }

        public IList<CartProducts> List()
        {
            return db.CartProducts.ToList();
        }

        public void Update(CartProducts Entity)
        {
            db.CartProducts.Update(Entity);
            Commit();
        }
    }
}
