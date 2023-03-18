using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class MasterMenuRepository : InterfaceSystemWebDorms<MasterMenu>
    {
        public AppDbContext DbContext { get; }
        public MasterMenuRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(MasterMenu entity)
        {
            DbContext.MasterMenus.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, MasterMenu entity)
        {
            var data = Find(id);
            DbContext.MasterMenus.Remove(data);
            DbContext.SaveChanges();
        }

        public MasterMenu Find(int Id)
        {
            return DbContext.MasterMenus.SingleOrDefault(x => x.MasterMenuId == Id);
        }

        public void Update(int id, MasterMenu entity)
        {
            DbContext.MasterMenus.Update(entity);
            DbContext.SaveChanges();
        }

        public List<MasterMenu> View()
        {
            return DbContext.MasterMenus.Include(x => x.MasterDorm).Where(x => x.IsDelete == false).ToList();


        }

        public List<MasterMenu> ViewClient()
        {
            return DbContext.MasterMenus.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, MasterMenu entity)
        {
            var data = Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;
            }
            else if (data.IsActive == false)

            {
                data.IsActive = true;
            }
            DbContext.SaveChanges();
        }
    }
}
