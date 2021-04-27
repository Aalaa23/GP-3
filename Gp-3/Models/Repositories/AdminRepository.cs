using Gp_3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    public class AdminRepository : IShoppingRepository<Admin>
    {
        ShoppingDbContext db;
        public AdminRepository(ShoppingDbContext _db)
        {
            db = _db;
        }
        public void Add(Admin Entity)
        {
            db.Admins.Add(Entity);
            Commit();
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var Admin = db.Admins.Find(id);
            db.Admins.Remove(Admin);
            Commit();
        }

        public Admin Find(int id)
        {
            var Admin = db.Admins.SingleOrDefault(a => a.AdminID == id);
            return Admin;
        }

        public IList<Admin> List()
        {
            return db.Admins.ToList();
        }
    

        public void Update(Admin Entity)
        {
            db.Admins.Update(Entity);
            Commit();
        }
    }
}
