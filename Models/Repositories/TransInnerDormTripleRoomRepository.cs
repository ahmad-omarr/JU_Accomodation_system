using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class TransInnerDormTripleRoomRepository : InterfaceSystemWebDorms<TransInnerDormTripleRoom>
    {
        public AppDbContext DbContext { get; }
        public TransInnerDormTripleRoomRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TransInnerDormTripleRoom entity)
        {
            DbContext.TransInnerDormTripleRooms.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, TransInnerDormTripleRoom entity)
        {
            var data = Find(id);
            DbContext.TransInnerDormTripleRooms.Remove(data);
            DbContext.SaveChanges();
        }

        public TransInnerDormTripleRoom Find(int Id)
        {
            return DbContext.TransInnerDormTripleRooms.SingleOrDefault(x => x.TransInnerDormTripleRoomId == Id);
        }

        public void Update(int id, TransInnerDormTripleRoom entity)
        {
            DbContext.TransInnerDormTripleRooms.Update(entity);
            DbContext.SaveChanges();
        }

        public List<TransInnerDormTripleRoom> View()
        {
            return DbContext.TransInnerDormTripleRooms.Include(x => x.MasterDorm).Where(x => x.IsDelete == false).ToList();
        }

        public List<TransInnerDormTripleRoom> ViewClient()
        {
            return DbContext.TransInnerDormTripleRooms.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, TransInnerDormTripleRoom entity)
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
