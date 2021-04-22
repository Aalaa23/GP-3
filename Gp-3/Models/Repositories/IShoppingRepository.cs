using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models.Repositories
{
    interface IShoppingRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity Entity);
        void Update(int id,TEntity Entity);
        void Delete(int id);
        List<TEntity> Search(string term);

    }
}
