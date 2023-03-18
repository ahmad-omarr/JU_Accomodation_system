using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class TransInternationalDormNightRoomRepository : InterfaceSystemWebDorms<TransInternationalDormNightRoom>
    {
        public AppDbContext DbContext { get; }
        public TransInternationalDormNightRoomRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TransInternationalDormNightRoom entity)
        {
            DbContext.TransInternationalDormNightRooms.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, TransInternationalDormNightRoom entity)
        {
            var data = Find(id);
            DbContext.TransInternationalDormNightRooms.Remove(data);
            DbContext.SaveChanges();
        }

        public TransInternationalDormNightRoom Find(int Id)
        {
            return DbContext.TransInternationalDormNightRooms.SingleOrDefault(x => x.TransInternationalDormNightRoomId == Id);
        }

        public void Update(int id, TransInternationalDormNightRoom entity)
        {
            DbContext.TransInternationalDormNightRooms.Update(entity);
            DbContext.SaveChanges();
        }

        public List<TransInternationalDormNightRoom> View()
        {
            return DbContext.TransInternationalDormNightRooms.Include(x => x.MasterDorm).Where(x => x.IsDelete == false).ToList();
        }

        public List<TransInternationalDormNightRoom> ViewClient()
        {
            return DbContext.TransInternationalDormNightRooms.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, TransInternationalDormNightRoom entity)
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
