using Gp_3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class CartRepository : IShoppingRepository<Cart>
    {
        ShoppingDbContext db;
        public CartRepository(ShoppingDbContext _db)
        {
            db = _db;
        }

        public void Add(Cart Entity)
        {
            db.Carts.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var cart = Find(id);
            db.Carts.Remove(cart);
            Commit();
        }

        public Cart Find(int id)
        {
            var cart = db.Carts.SingleOrDefault(a => a.CartID == id);
            return cart;
        }

        public IList<Cart> List()
        {
            return db.Carts.ToList();
        }

        public void Update(Cart Entity)
        {
          db.Update(Entity);
            Commit();  
        }
    }
}
