using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
     public interface IShoppingRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity Entity);
        void Update(TEntity Entity);
        void Delete(int id);
        void Commit();

    }
}
