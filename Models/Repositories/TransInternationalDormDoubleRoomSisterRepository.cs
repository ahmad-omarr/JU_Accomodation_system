using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models.Repositories
{
    public class TransInternationalDormDoubleRoomSisterRepository : InterfaceSystemWebDorms<TransInternationalDormDoubleRoomSister>
    {
        public AppDbContext DbContext { get; }
        public TransInternationalDormDoubleRoomSisterRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TransInternationalDormDoubleRoomSister entity)
        {
            DbContext.TransInternationalDormDoubleRoomSisters.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(int id, TransInternationalDormDoubleRoomSister entity)
        {
            var data = Find(id);
            DbContext.TransInternationalDormDoubleRoomSisters.Remove(data);
            DbContext.SaveChanges();
        }

        public TransInternationalDormDoubleRoomSister Find(int Id)
        {
            return DbContext.TransInternationalDormDoubleRoomSisters.SingleOrDefault(x => x.TransInternationalDormDoubleRoomSisterId == Id);
        }

        public void Update(int id, TransInternationalDormDoubleRoomSister entity)
        {
            DbContext.TransInternationalDormDoubleRoomSisters.Update(entity);
            DbContext.SaveChanges();
        }

        public List<TransInternationalDormDoubleRoomSister> View()
        {
            return DbContext.TransInternationalDormDoubleRoomSisters.Include(x => x.MasterDorm).Where(x => x.IsDelete == false).ToList();
        }

        public List<TransInternationalDormDoubleRoomSister> ViewClient()
        {
            return DbContext.TransInternationalDormDoubleRoomSisters.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
        public void Update_Active(int id, TransInternationalDormDoubleRoomSister entity)
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
