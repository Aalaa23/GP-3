using Gp_3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class OrderDetailsRepository : IShoppingRepository<OrderDetails>
    {
        ShoppingDbContext db;
        public OrderDetailsRepository(ShoppingDbContext _db)
        {
            db = _db;
        }

        public void Add(OrderDetails Entity)
        {
            db.OrderDetails.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var orderDetails = db.OrderDetails.Find(id);
            db.Remove(orderDetails);
            Commit();
        }

        public OrderDetails Find(int id)
        {
            var orderDetails = db.OrderDetails.SingleOrDefault(a=> a.OrderDetailsID == id);
            return orderDetails;
        }

        public IList<OrderDetails> List()
        {
            return db.OrderDetails.ToList();
        }

        public void Update(OrderDetails Entity)
        {
            db.OrderDetails.Update(Entity);
            Commit();
        }
    }
}
