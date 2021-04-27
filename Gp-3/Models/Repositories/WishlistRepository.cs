using Gp_3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class WishlistRepository : IShoppingRepository<WishList>
    {
        ShoppingDbContext db;
        public WishlistRepository(ShoppingDbContext _db)
        {
            db = _db;
        }
        public void Add(WishList Entity)
        {
            db.WishLists.Add(Entity);
            Commit();
        }

            public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var wishlist = db.WishLists.Find(id);
            db.WishLists.Remove(wishlist);
            Commit();
        }

        public WishList Find(int id)
        {

            var wishlist = db.WishLists.SingleOrDefault(a => a.WishListID == id);
            return wishlist;
        }

        public IList<WishList> List()
        {
            return db.WishLists.ToList();
        }

        public void Update(WishList Entity)
        {
            db.WishLists.Update(Entity);
            Commit();
        }
    }
}
