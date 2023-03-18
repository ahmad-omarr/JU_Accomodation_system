using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemWebDorms.Models;
using SystemWebDorms.Models.Repositories;

namespace SystemWebDorms.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class MasterMenuController : Controller
    {
        public InterfaceSystemWebDorms<MasterDorm> MasterDorm { get; }
        public IHostingEnvironment Hosting { get; }
        public InterfaceSystemWebDorms<MasterMenu> MasterMenu { get; }

        public MasterMenuController(InterfaceSystemWebDorms<MasterMenu> _MasterMenu, InterfaceSystemWebDorms<MasterDorm> _MasterDorm, IHostingEnvironment hosting)
        {
            MasterDorm = _MasterDorm;
            Hosting = hosting;
            MasterMenu = _MasterMenu;

        }
        // GET: TransInnerDormDoubleRoomController
        public ActionResult Index()
        {
            var data = MasterMenu.View();

            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Details/5
        public ActionResult Details(int id)
        {
            var data = MasterMenu.Find(id);
            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Create
        public ActionResult Create()
        {
            MasterMenu obj2 = new MasterMenu
            {
                ListMasterDorm = MasterDorm.View()
            };
            return View(obj2);
        }

        // POST: TransInnerDormDoubleRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterMenu collection)
        {
            try
            {


                MasterMenu obj3 = new MasterMenu
                {
                    MasterMenuId = collection.MasterMenuId,
                    MasterMenuDropMenu = collection.MasterMenuDropMenu,
                    MasterMenuDropMenuLink = collection.MasterMenuDropMenuLink,
                    MasterMenuLinkUrl = collection.MasterMenuLinkUrl,
                    MasterMenuName = collection.MasterMenuName,

                    IsActive = true,
                    IsDelete = false,

                    MasterDormId = collection.MasterDormId,
                    
                };
                MasterMenu.Add(obj3);
                return RedirectToAction(nameof(Index));
            }


            catch
            {
                return View();
            }
        }

        // GET: TransInnerDormDoubleRoomController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterMenu.Find(id);
            MasterMenu obj4 = new MasterMenu();
            obj4.MasterMenuId = data.MasterMenuId;
            obj4.MasterMenuDropMenu = data.MasterMenuDropMenu;
            obj4.MasterMenuDropMenuLink = data.MasterMenuDropMenuLink;
            obj4.MasterMenuLinkUrl = data.MasterMenuLinkUrl;
            obj4.MasterMenuName = data.MasterMenuName;
           
            obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);

            ViewBag.AA = MasterDorm.View();

            return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterMenu collection)
        {
            try
            {

                MasterMenu obj5 = new MasterMenu
                {
                    MasterMenuId = collection.MasterMenuId,
                    MasterMenuDropMenu = collection.MasterMenuDropMenu,
                    MasterMenuDropMenuLink = collection.MasterMenuDropMenuLink,
                    MasterMenuLinkUrl = collection.MasterMenuLinkUrl,
                    MasterMenuName = collection.MasterMenuName,

                    IsActive = true,
                    IsDelete = false,

                    MasterDorm = MasterDorm.Find(collection.MasterDormId),
                    
                };
                MasterMenu.Update(id, obj5);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransInnerDormDoubleRoomController/Delete/5
        public ActionResult Delete(int id , MasterMenu collection)
        {
            var data = MasterMenu.Find(id);
            //MasterMenu obj4 = new MasterMenu();
            //obj4.MasterMenuId = data.MasterMenuId;
            //obj4.MasterMenuDropMenu = data.MasterMenuDropMenu;
            //obj4.MasterMenuDropMenuLink = data.MasterMenuDropMenuLink;
            //obj4.MasterMenuLinkUrl = data.MasterMenuLinkUrl;
            //obj4.MasterMenuName = data.MasterMenuName;
            //obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);
            //ViewBag.AA = MasterDorm.View();

            data.IsDelete = true;
            MasterMenu.Update(id, data);
            return RedirectToAction(nameof(Index));

        }

        // POST: TransInnerDormDoubleRoomController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, MasterMenu collection)
        //{
        //    try
        //    {
        //        var data = MasterMenu.Find(id);
        //        data.IsDelete = true;
        //        MasterMenu.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = MasterMenu.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            MasterMenu.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        
    }
}
