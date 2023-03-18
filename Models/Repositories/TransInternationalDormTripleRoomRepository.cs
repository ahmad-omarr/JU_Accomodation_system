using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class TransInternationalDormTripleRoomRepository : InterfaceSystemWebDorms<TransInternationalDormTripleRoom>
    {
        public AppDbContext DbContext { get; }

        public TransInternationalDormTripleRoomRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TransInternationalDormTripleRoom entity)
        {
            DbContext.TransInternationalDormTripleRooms.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, TransInternationalDormTripleRoom entity)
        {
            var data = Find(id);

            DbContext.TransInternationalDormTripleRooms.Remove(data);
            DbContext.SaveChanges();
        }

        public TransInternationalDormTripleRoom Find(int Id)
        {
            return DbContext.TransInternationalDormTripleRooms.SingleOrDefault(x => x.TransInternationalDormTripleRoomId == Id);
        }

        public void Update(int id, TransInternationalDormTripleRoom entity)
        {
            DbContext.TransInternationalDormTripleRooms.Update(entity);
            DbContext.SaveChanges();
        }

        public List<TransInternationalDormTripleRoom> View()
        {
            return DbContext.TransInternationalDormTripleRooms.Include(x => x.MasterDorm).Where(x => x.IsDelete == false).ToList();
        }

        public List<TransInternationalDormTripleRoom> ViewClient()
        {
            return DbContext.TransInternationalDormTripleRooms.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, TransInternationalDormTripleRoom entity)
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
