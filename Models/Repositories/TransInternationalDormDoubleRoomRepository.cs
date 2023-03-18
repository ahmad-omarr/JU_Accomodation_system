using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class TransInternationalDormDoubleRoomRepository : InterfaceSystemWebDorms<TransInternationalDormDoubleRoom>
    {
        public AppDbContext DbContext { get; }
        public TransInternationalDormDoubleRoomRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TransInternationalDormDoubleRoom entity)
        {
            DbContext.TransInternationalDormDoubleRooms.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, TransInternationalDormDoubleRoom entity)
        {
            var data = Find(id);
            DbContext.TransInternationalDormDoubleRooms.Remove(data);
            DbContext.SaveChanges();
        }

        public TransInternationalDormDoubleRoom Find(int Id)
        {
            return DbContext.TransInternationalDormDoubleRooms.SingleOrDefault(x => x.TransInternationalDormDoubleRoomId == Id);
        }

        public void Update(int id, TransInternationalDormDoubleRoom entity)
        {
            DbContext.TransInternationalDormDoubleRooms.Update(entity);
            DbContext.SaveChanges();
        }

        public List<TransInternationalDormDoubleRoom> View()
        {
            return DbContext.TransInternationalDormDoubleRooms.Include(x => x.MasterDorm).Where(x => x.IsDelete == false).ToList();
        }

        public List<TransInternationalDormDoubleRoom> ViewClient()
        {
            return DbContext.TransInternationalDormDoubleRooms.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, TransInternationalDormDoubleRoom entity)
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
