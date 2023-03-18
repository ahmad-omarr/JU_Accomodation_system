using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class MasterDormRepository : InterfaceSystemWebDorms<MasterDorm>
    {
        public AppDbContext DbContext { get; }
        public MasterDormRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(MasterDorm entity)
        {
            DbContext.MasterDormitories.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, MasterDorm entity)
        {
            var data = Find(id);
            DbContext.MasterDormitories.Remove(data);
            DbContext.SaveChanges();
        }

        public MasterDorm Find(int Id)
        {
            return DbContext.MasterDormitories.SingleOrDefault(x => x.MasterDormId == Id);
        }

        public void Update(int id, MasterDorm entity)
        {
            DbContext.MasterDormitories.Update(entity);
            DbContext.SaveChanges();
        }

        public List<MasterDorm> View()
        {
            return DbContext.MasterDormitories.Where(x => x.IsDelete == false).ToList();
        }

        public List<MasterDorm> ViewClient()
        {
            return DbContext.MasterDormitories.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, MasterDorm entity)
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
