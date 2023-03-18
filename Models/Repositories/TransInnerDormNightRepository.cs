using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class TransInnerDormNightRepository : InterfaceSystemWebDorms<TransInnerDormNight>
    {
        public AppDbContext DbContext { get; }
        public TransInnerDormNightRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TransInnerDormNight entity)
        {
            DbContext.TransInnerDormNights.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, TransInnerDormNight entity)
        {
            var data = Find(id);
            DbContext.TransInnerDormNights.Remove(data);
            DbContext.SaveChanges();
        }

        public TransInnerDormNight Find(int Id)
        {
            return DbContext.TransInnerDormNights.SingleOrDefault(x => x.TransInnerDormNightId == Id);
        }

        public void Update(int id, TransInnerDormNight entity)
        {
            DbContext.TransInnerDormNights.Update(entity);
            DbContext.SaveChanges();
        }

        public List<TransInnerDormNight> View()
        {
            return DbContext.TransInnerDormNights.Include(x => x.MasterDorm).Where(x => x.IsDelete == false).ToList();
        }

        public List<TransInnerDormNight> ViewClient()
        {
            return DbContext.TransInnerDormNights.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, TransInnerDormNight entity)
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
