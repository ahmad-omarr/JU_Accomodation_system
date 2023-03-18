using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class MasterSocialMediumRepository : InterfaceSystemWebDorms<MasterSocialMedium>
    {
        public AppDbContext DbContext { get; }
        public MasterSocialMediumRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(MasterSocialMedium entity)
        {
            DbContext.MasterSocialMedia.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, MasterSocialMedium entity)
        {
            var data = Find(id);
            DbContext.MasterSocialMedia.Remove(data);
            DbContext.SaveChanges();
        }

        public MasterSocialMedium Find(int Id)
        {
            return DbContext.MasterSocialMedia.SingleOrDefault(x => x.MasterSocialMediumId == Id);
        }

        public void Update(int id, MasterSocialMedium entity)
        {
            DbContext.MasterSocialMedia.Update(entity);
            DbContext.SaveChanges();
        }

        public List<MasterSocialMedium> View()
        {
            return DbContext.MasterSocialMedia.Where(x => x.IsDelete == false).ToList();
        }

        public List<MasterSocialMedium> ViewClient()
        {
            return DbContext.MasterSocialMedia.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, MasterSocialMedium entity)
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
