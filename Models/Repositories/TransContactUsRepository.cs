using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class TransContactUsRepository : InterfaceSystemWebDorms<TransContactUs>
    {
        public AppDbContext DbContext { get; }
        public TransContactUsRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TransContactUs entity)
        {
            DbContext.TransContactUss.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, TransContactUs entity)
        {
            var data = Find(id);
            DbContext.TransContactUss.Remove(data);
            DbContext.SaveChanges();
        }

        public TransContactUs Find(int Id)
        {
            return DbContext.TransContactUss.SingleOrDefault(x => x.TransContactUsId == Id);
        }

        public void Update(int id, TransContactUs entity)
        {
            DbContext.TransContactUss.Update(entity);
            DbContext.SaveChanges();
        }

        public List<TransContactUs> View()
        {
            return DbContext.TransContactUss.Where(x => x.IsDelete == false).ToList();
        }

        public List<TransContactUs> ViewClient()
        {
            return DbContext.TransContactUss.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, TransContactUs entity)
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
