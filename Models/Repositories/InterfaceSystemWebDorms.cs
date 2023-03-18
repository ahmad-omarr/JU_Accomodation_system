using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public interface InterfaceSystemWebDorms<TEntity>
    {
        List<TEntity> View();
        List<TEntity> ViewClient();


        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id, TEntity entity);

        TEntity Find(int Id);
    }
}
