using Gp_3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class CustomerRepository : IShoppingRepository<Customer>
    {
        private readonly ShoppingDbContext db;
        public CustomerRepository(ShoppingDbContext _db)
        {
            db = _db;
        }
        public void Add(Customer Entity)
        {
            db.Customers.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var Customer = db.Customers.Find(id);
            db.Customers.Remove(Customer);
            Commit();
        }

        public Customer Find(int id)
        {
            var Customer = db.Customers.SingleOrDefault(a => a.CustomerID == id);
            return Customer;
        }

        public IList<Customer> List()
        {
            return db.Customers.ToList();
        }

        public void Update(Customer Entity)
        {
            db.Update(Entity);
            Commit();
        }
    }
}
