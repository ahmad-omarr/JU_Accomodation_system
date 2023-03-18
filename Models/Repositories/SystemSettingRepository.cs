using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class SystemSettingRepository : InterfaceSystemWebDorms<SystemSetting>
    {
        public AppDbContext DbContext { get; }
        public SystemSettingRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(SystemSetting entity)
        {
            DbContext.SystemSettings.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, SystemSetting entity)
        {
            var data = Find(id);
            DbContext.SystemSettings.Remove(data);
            DbContext.SaveChanges();
        }

        public SystemSetting Find(int Id)
        {
            return DbContext.SystemSettings.SingleOrDefault(x => x.SystemSettingId == Id);
        }

        public void Update(int id, SystemSetting entity)
        {
            DbContext.SystemSettings.Update(entity);
            DbContext.SaveChanges();
        }

        public List<SystemSetting> View()
        {
            return DbContext.SystemSettings.Where(x => x.IsDelete == false).ToList();
        }

        public List<SystemSetting> ViewClient()
        {
            return DbContext.SystemSettings.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, SystemSetting entity)
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
