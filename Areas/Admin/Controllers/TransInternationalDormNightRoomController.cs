using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SystemWebDorms.Areas.Admin.ViewModels;
using SystemWebDorms.Models;
using SystemWebDorms.Models.Repositories;

namespace SystemWebDorms.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class TransInternationalDormNightRoomController : Controller
    {
        public InterfaceSystemWebDorms<MasterDorm> MasterDorm { get; }
        public IHostingEnvironment Hosting { get; }
        public InterfaceSystemWebDorms<TransInternationalDormNightRoom> TransInternationalDormNightRoom { get; }

        public TransInternationalDormNightRoomController(InterfaceSystemWebDorms<TransInternationalDormNightRoom> _TransInternationalDormNightRoom, InterfaceSystemWebDorms<MasterDorm> _MasterDorm, IHostingEnvironment hosting)
        {
            MasterDorm = _MasterDorm;
            Hosting = hosting;
            TransInternationalDormNightRoom = _TransInternationalDormNightRoom;

        }
        // GET: TransInnerDormDoubleRoomController
        public ActionResult Index()
        {
            var data = TransInternationalDormNightRoom.View();

            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Details/5
        public ActionResult Details(int id)
        {
            var data = TransInternationalDormNightRoom.Find(id);
            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Create
        public ActionResult Create()
        {
            VM_TransInternationalDormNightRoom obj2 = new VM_TransInternationalDormNightRoom
            {
                ListMasterDorm = MasterDorm.View()
            };
            return View(obj2);
        }

        // POST: TransInnerDormDoubleRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VM_TransInternationalDormNightRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Ammon);
                FileImge2 = SaveImage(collection.File_Jerash);

                TransInternationalDormNightRoom obj3 = new TransInternationalDormNightRoom
                {
                    TransInternationalDormNightRoomId = collection.TransInternationalDormNightRoomId,
                    TransJarashDormNightRoomTitle = collection.TransJarashDormNightRoomTitle,
                    TransJerashDormNightRoomBrief = collection.TransJerashDormNightRoomBrief,
                    TransAmmonDormNightRoomLinkUrl = collection.TransAmmonDormNightRoomLinkUrl,
                    TransJerashDormNightRoomLinkUrl = collection.TransJerashDormNightRoomLinkUrl,
                    TransAmmonDormNightRoomTitle = collection.TransAmmonDormNightRoomTitle,
                    TransAmmonDormNightRoomBrief = collection.TransAmmonDormNightRoomBrief,



                    IsActive = true,
                    IsDelete = false,

                    MasterDormId = collection.MasterDormId,
                    //LookupCategoryMenu = LookupCategoryMenu.Find(collection.LookupCategoryMenuId),
                    TransJerashDormNightRoomImage = FileImge1,
                    TransAmmonDormNightRoomImage = FileImge2,
                };
                TransInternationalDormNightRoom.Add(obj3);
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
            var data = TransInternationalDormNightRoom.Find(id);
            VM_TransInternationalDormNightRoom obj4 = new VM_TransInternationalDormNightRoom();
            obj4.TransInternationalDormNightRoomId = data.TransInternationalDormNightRoomId;
            obj4.TransJarashDormNightRoomTitle = data.TransJarashDormNightRoomTitle;
            obj4.TransJerashDormNightRoomBrief = data.TransJerashDormNightRoomBrief;
            obj4.TransJerashDormNightRoomImage = data.TransJerashDormNightRoomImage;
            obj4.TransJerashDormNightRoomLinkUrl = data.TransJerashDormNightRoomLinkUrl;
            obj4.TransAmmonDormNightRoomTitle = data.TransAmmonDormNightRoomTitle;
            obj4.TransAmmonDormNightRoomBrief = data.TransAmmonDormNightRoomBrief;
            obj4.TransAmmonDormNightRoomImage = data.TransAmmonDormNightRoomImage;
            obj4.TransAmmonDormNightRoomLinkUrl = data.TransAmmonDormNightRoomLinkUrl;
            obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);

            obj4.ListMasterDorm = MasterDorm.View();

            return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_TransInternationalDormNightRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Ammon);
                FileImge2 = SaveImage(collection.File_Jerash);
                TransInternationalDormNightRoom obj5 = new TransInternationalDormNightRoom
                {
                    TransInternationalDormNightRoomId = collection.TransInternationalDormNightRoomId,
                    TransJarashDormNightRoomTitle = collection.TransJarashDormNightRoomTitle,
                    TransJerashDormNightRoomBrief = collection.TransJerashDormNightRoomBrief,
                    TransAmmonDormNightRoomLinkUrl = collection.TransAmmonDormNightRoomLinkUrl,
                    TransJerashDormNightRoomLinkUrl = collection.TransJerashDormNightRoomLinkUrl,
                    TransAmmonDormNightRoomTitle = collection.TransAmmonDormNightRoomTitle,
                    TransAmmonDormNightRoomBrief = collection.TransAmmonDormNightRoomBrief,
                    IsActive = true,
                    IsDelete = false,

                    MasterDorm = MasterDorm.Find(collection.MasterDormId),
                    TransAmmonDormNightRoomImage = (FileImge1 == "" ? collection.TransAmmonDormNightRoomImage : FileImge1),
                    TransJerashDormNightRoomImage = (FileImge2 == "" ? collection.TransJerashDormNightRoomImage : FileImge2),

                    //LookupProductImageUrl = FileImge,
                };
                TransInternationalDormNightRoom.Update(id, obj5);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransInnerDormDoubleRoomController/Delete/5
        public ActionResult Delete(int id, TransInternationalDormNightRoom collection)
        {
            var data = TransInternationalDormNightRoom.Find(id);
            data.IsDelete = true;
            TransInternationalDormNightRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
        }

        // POST: TransInnerDormDoubleRoomController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, TransInternationalDormNightRoom collection)
        //{
        //    try
        //    {
        //        var data = TransInternationalDormNightRoom.Find(id);
        //        data.IsDelete = true;
        //        TransInternationalDormNightRoom.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = TransInternationalDormNightRoom.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            TransInternationalDormNightRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                Guid obj = Guid.NewGuid();

                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/TransInternationalDormNightRoom");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + obj + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;
        }
    }
}
