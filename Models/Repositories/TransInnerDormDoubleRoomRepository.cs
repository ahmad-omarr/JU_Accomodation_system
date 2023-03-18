using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class TransInnerDormDoubleRoomRepository : InterfaceSystemWebDorms<TransInnerDormDoubleRoom>
    {
        public AppDbContext DbContext { get; }
        public TransInnerDormDoubleRoomRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TransInnerDormDoubleRoom entity)
        {
            DbContext.TransInnerDormDoubleRooms.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, TransInnerDormDoubleRoom entity)
        {
            var data = Find(id);
            DbContext.TransInnerDormDoubleRooms.Remove(data);
            DbContext.SaveChanges();
        }

        public TransInnerDormDoubleRoom Find(int Id)
        {
            return DbContext.TransInnerDormDoubleRooms.SingleOrDefault(x => x.TransInnerDormDoubleRoomId == Id);
        }

        public void Update(int id, TransInnerDormDoubleRoom entity)
        {
            DbContext.TransInnerDormDoubleRooms.Update(entity);
            DbContext.SaveChanges();
        }

        public List<TransInnerDormDoubleRoom> View()
        {
            return DbContext.TransInnerDormDoubleRooms.Include(x => x.MasterDorm).Where(x => x.IsDelete == false).ToList();
        }

        public List<TransInnerDormDoubleRoom> ViewClient()
        {
            return DbContext.TransInnerDormDoubleRooms.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, TransInnerDormDoubleRoom entity)
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
