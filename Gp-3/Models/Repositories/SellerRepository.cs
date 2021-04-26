using Gp_3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class SellerRepository : IShoppingRepository<Seller>
    {

        ShoppingDbContext db;
        public SellerRepository(ShoppingDbContext _db)
        {
            db = _db;
        }
        public void Add(Seller Entity)
        {
            db.Sellers.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var Seller = db.Sellers.Find(id);
            db.Sellers.Remove(Seller);
            Commit();
        }

        public Seller Find(int id)
        {
            var Seller = db.Sellers.SingleOrDefault(a => a.SellerID == id);
            return Seller;
        }

        public IList<Seller> List()
        {
            return db.Sellers.ToList();
        }

        public void Update(Seller Entity)
        {
            db.Sellers.Update(Entity);
            Commit();
        }
    }
}
