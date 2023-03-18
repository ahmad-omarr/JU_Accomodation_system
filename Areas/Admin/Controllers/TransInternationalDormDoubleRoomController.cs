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
    public class TransInternationalDormDoubleRoomController : Controller
    {
        public InterfaceSystemWebDorms<MasterDorm> MasterDorm { get; }
        public IHostingEnvironment Hosting { get; }
        public InterfaceSystemWebDorms<TransInternationalDormDoubleRoom> TransInternationalDormDoubleRoom { get; }

        public TransInternationalDormDoubleRoomController(InterfaceSystemWebDorms<TransInternationalDormDoubleRoom> _TransInternationalDormDoubleRoom, InterfaceSystemWebDorms<MasterDorm> _MasterDorm, IHostingEnvironment hosting)
        {
            MasterDorm = _MasterDorm;
            Hosting = hosting;
            TransInternationalDormDoubleRoom = _TransInternationalDormDoubleRoom;

        }
        // GET: TransInnerDormDoubleRoomController
        public ActionResult Index()
        {
            var data = TransInternationalDormDoubleRoom.View();

            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Details/5
        public ActionResult Details(int id)
        {
            var data = TransInternationalDormDoubleRoom.Find(id);
            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Create
        public ActionResult Create()
        {
            VM_TransInternationalDormDoubleRoom obj2 = new VM_TransInternationalDormDoubleRoom
            {
                ListMasterDorm = MasterDorm.View()
            };
            return View(obj2);
        }

        // POST: TransInnerDormDoubleRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VM_TransInternationalDormDoubleRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Jerash);
                FileImge2 = SaveImage(collection.File_Ammon);
                TransInternationalDormDoubleRoom obj3 = new TransInternationalDormDoubleRoom
                {
                    TransInternationalDormDoubleRoomId = collection.TransInternationalDormDoubleRoomId,
                    TransJarashDormDoubleRoomTitle = collection.TransJarashDormDoubleRoomTitle,
                    TransJerashDormDoubleRoomBrief = collection.TransJerashDormDoubleRoomBrief,
                    TransAmmonDormDoubleRoomLinkUrl = collection.TransAmmonDormDoubleRoomLinkUrl,
                    TransJerashDormDoubleRoomLinkUrl = collection.TransJerashDormDoubleRoomLinkUrl,
                    TransAmmonDormDoubleRoomTitle = collection.TransAmmonDormDoubleRoomTitle,
                    TransAmmonDormDoubleRoomBrief = collection.TransAmmonDormDoubleRoomBrief,



                    IsActive = true,
                    IsDelete = false,

                    MasterDormId = collection.MasterDormId,
                    //LookupCategoryMenu = LookupCategoryMenu.Find(collection.LookupCategoryMenuId),
                    TransJerashDormDoubleRoomImage = FileImge1,
                    TransAmmonDormDoubleRoomImage = FileImge2,
                };
                TransInternationalDormDoubleRoom.Add(obj3);
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
            var data = TransInternationalDormDoubleRoom.Find(id);
            VM_TransInternationalDormDoubleRoom obj4 = new VM_TransInternationalDormDoubleRoom();
            obj4.TransInternationalDormDoubleRoomId = data.TransInternationalDormDoubleRoomId;
            obj4.TransJarashDormDoubleRoomTitle = data.TransJarashDormDoubleRoomTitle;
            obj4.TransJerashDormDoubleRoomBrief = data.TransJerashDormDoubleRoomBrief;
            obj4.TransJerashDormDoubleRoomImage = data.TransJerashDormDoubleRoomImage;
            obj4.TransJerashDormDoubleRoomLinkUrl = data.TransJerashDormDoubleRoomLinkUrl;
            obj4.TransAmmonDormDoubleRoomTitle = data.TransAmmonDormDoubleRoomTitle;
            obj4.TransAmmonDormDoubleRoomBrief = data.TransAmmonDormDoubleRoomBrief;
            obj4.TransAmmonDormDoubleRoomImage = data.TransAmmonDormDoubleRoomImage;
            obj4.TransAmmonDormDoubleRoomLinkUrl = data.TransAmmonDormDoubleRoomLinkUrl;
            obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);

            obj4.ListMasterDorm = MasterDorm.View();

            return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_TransInternationalDormDoubleRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Jerash);
                FileImge2 = SaveImage(collection.File_Ammon);
                TransInternationalDormDoubleRoom obj5 = new TransInternationalDormDoubleRoom
                {
                    TransInternationalDormDoubleRoomId = collection.TransInternationalDormDoubleRoomId,
                    TransJarashDormDoubleRoomTitle = collection.TransJarashDormDoubleRoomTitle,
                    TransJerashDormDoubleRoomBrief = collection.TransJerashDormDoubleRoomBrief,
                    TransAmmonDormDoubleRoomLinkUrl = collection.TransAmmonDormDoubleRoomLinkUrl,
                    TransJerashDormDoubleRoomLinkUrl = collection.TransJerashDormDoubleRoomLinkUrl,
                    TransAmmonDormDoubleRoomTitle = collection.TransAmmonDormDoubleRoomTitle,
                    TransAmmonDormDoubleRoomBrief = collection.TransAmmonDormDoubleRoomBrief,
                    IsActive = true,
                    IsDelete = false,

                    MasterDorm = MasterDorm.Find(collection.MasterDormId),
                    TransAmmonDormDoubleRoomImage = (FileImge1 == "" ? collection.TransAmmonDormDoubleRoomImage : FileImge1),
                    TransJerashDormDoubleRoomImage = (FileImge2 == "" ? collection.TransJerashDormDoubleRoomImage : FileImge2),

                    //LookupProductImageUrl = FileImge,
                };
                TransInternationalDormDoubleRoom.Update(id, obj5);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransInnerDormDoubleRoomController/Delete/5
        public ActionResult Delete(int id, TransInternationalDormDoubleRoom collection)
        {
            var data = TransInternationalDormDoubleRoom.Find(id);
            data.IsDelete = true;
            TransInternationalDormDoubleRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
    

        // POST: TransInnerDormDoubleRoomController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, TransInternationalDormDoubleRoom collection)
        //{
        //    try
        //    {
        //        var data = TransInternationalDormDoubleRoom.Find(id);
        //        data.IsDelete = true;
        //        TransInternationalDormDoubleRoom.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = TransInternationalDormDoubleRoom.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            TransInternationalDormDoubleRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                Guid obj = Guid.NewGuid();

                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/TransInternationalDormDoubleRoom");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + obj + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;
        }
    }
}
