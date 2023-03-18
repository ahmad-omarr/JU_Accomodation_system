using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class TransInternationalDormSingleRoomRepository : InterfaceSystemWebDorms<TransInternationalDormSingleRoom>
    {
        public AppDbContext DbContext { get; }

        public TransInternationalDormSingleRoomRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TransInternationalDormSingleRoom entity)
        {
            DbContext.TransInternationalDormSingleRooms.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, TransInternationalDormSingleRoom entity)
        {
            
            var data = Find(id);

            DbContext.TransInternationalDormSingleRooms.Remove(data);
            DbContext.SaveChanges();
        }

        public TransInternationalDormSingleRoom Find(int Id)
        {
            return DbContext.TransInternationalDormSingleRooms.SingleOrDefault(x => x.TransInternationalDormSingleRoomId == Id);
        }

        public void Update(int id, TransInternationalDormSingleRoom entity)
        {
            DbContext.TransInternationalDormSingleRooms.Update(entity);
            DbContext.SaveChanges();
        }

        public List<TransInternationalDormSingleRoom> View()
        {
            return DbContext.TransInternationalDormSingleRooms.Include(x => x.MasterDorm).Where(x => x.IsDelete == false).ToList();
        }

        public List<TransInternationalDormSingleRoom> ViewClient()
        {
            return DbContext.TransInternationalDormSingleRooms.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, TransInternationalDormSingleRoom entity)
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
