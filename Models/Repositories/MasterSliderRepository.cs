using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class MasterSliderRepository : InterfaceSystemWebDorms<MasterSlider>
    {
        public AppDbContext DbContext { get; }
        public MasterSliderRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(MasterSlider entity)
        {
            DbContext.MasterSliders.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, MasterSlider entity)
        {
            var data = Find(id);
            DbContext.MasterSliders.Remove(data);
            DbContext.SaveChanges();
        }

        public MasterSlider Find(int Id)
        {
            return DbContext.MasterSliders.SingleOrDefault(x => x.MasterSliderId == Id);
        }

        public void Update(int id, MasterSlider entity)
        {
            DbContext.MasterSliders.Update(entity);
            DbContext.SaveChanges();
        }

        public List<MasterSlider> View()
        {
            return DbContext.MasterSliders.Where(x => x.IsDelete == false).ToList();
        }

        public List<MasterSlider> ViewClient()
        {
            return DbContext.MasterSliders.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, MasterSlider entity)
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
