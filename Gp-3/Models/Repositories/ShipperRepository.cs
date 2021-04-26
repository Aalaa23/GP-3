using Gp_3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class ShipperRepository : IShoppingRepository<Shipper>
    {

        ShoppingDbContext db;
        public ShipperRepository(ShoppingDbContext _db)
        {
            db = _db;
        }
        public void Add(Shipper Entity)
        {
            db.Shippers.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var Shipper = db.CartProducts.Find(id);
            db.CartProducts.Remove(Shipper);
            Commit();
        }

        public Shipper Find(int id)
        {
            Shipper Shipper = db.Shippers.SingleOrDefault(a => a.ShipperID == id);
            return Shipper;
        }

        public IList<Shipper> List()
        {
            return db.Shippers.ToList(); ;
        }

        public void Update(Shipper Entity)
        {
            db.Shippers.Update(Entity);
            Commit();
        }
    }
}
