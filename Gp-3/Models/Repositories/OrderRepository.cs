using System;
using Gp_3.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class OrderRepository : IShoppingRepository<Order>
    {
        ShoppingDbContext db;
        public OrderRepository(ShoppingDbContext _db)
        {
            db = _db;
        }
        public void Add(Order Entity)
        {
            db.Orders.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var order = db.Orders.Find(id);
            db.Orders.Remove(order);
            Commit();
        }

        public Order Find(int id)
        {
            var order = db.Orders.SingleOrDefault(a => a.OrderID == id);
            return order;
        }

        public IList<Order> List()
        {
            return db.Orders.ToList();
        }

        public void Update(Order Entity)
        {
            db.Orders.Update(Entity);
            Commit();
        }
    }
}
