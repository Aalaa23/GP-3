using Gp_3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class InventoryRepository : IShoppingRepository<Inventory>
    {
        ShoppingDbContext db;
        public InventoryRepository(ShoppingDbContext _db)
        {
            db = _db;
        }
        public void Add(Inventory Entity)
        {
            db.Inventories.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var inventory = db.Inventories.Find(id);
            db.Inventories.Remove(inventory);
            Commit();
        }

        public Inventory Find(int id)
        {
            var inventory = db.Inventories.SingleOrDefault(a => a.InventoryID == id);
            return inventory;
        }

        public IList<Inventory> List()
        {
            return db.Inventories.ToList();
        }

        public void Update(Inventory Entity)
        {
            db.Inventories.Update(Entity);
            Commit();
        }
    }
}
