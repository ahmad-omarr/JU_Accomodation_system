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
    [Area("Admin")]
    public class TransInternationalDormSingleRoomController : Controller
    {
        public InterfaceSystemWebDorms<MasterDorm> MasterDorm { get; }
        public IHostingEnvironment Hosting { get; }
        public InterfaceSystemWebDorms<TransInternationalDormSingleRoom> TransInternationalDormSingleRoom { get; }

        public TransInternationalDormSingleRoomController(InterfaceSystemWebDorms<TransInternationalDormSingleRoom> _TransInternationalDormSingleRoom, InterfaceSystemWebDorms<MasterDorm> _MasterDorm, IHostingEnvironment hosting)
        {
            MasterDorm = _MasterDorm;
            Hosting = hosting;
            TransInternationalDormSingleRoom = _TransInternationalDormSingleRoom;

        }
        // GET: TransInnerDormDoubleRoomController
        public ActionResult Index()
        {
            var data = TransInternationalDormSingleRoom.View();

            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Details/5
        public ActionResult Details(int id)
        {
            var data = TransInternationalDormSingleRoom.Find(id);
            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Create
        public ActionResult Create()
        {
            VM_TransInternationalDormSingleRoom obj2 = new VM_TransInternationalDormSingleRoom
            {
                ListMasterDorm = MasterDorm.View()
            };
            return View(obj2);
        }

        // POST: TransInnerDormDoubleRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VM_TransInternationalDormSingleRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Jerash);
                FileImge2 = SaveImage(collection.File_Ammon);

                TransInternationalDormSingleRoom obj3 = new TransInternationalDormSingleRoom
                {
                    TransInternationalDormSingleRoomId = collection.TransInternationalDormSingleRoomId,
                    TransJarashDormSingleRoomTitle = collection.TransJarashDormSingleRoomTitle,
                    TransJerashDormSingleRoomBrief = collection.TransJerashDormSingleRoomBrief,
                    TransAmmonDormSingleRoomLinkUrl = collection.TransAmmonDormSingleRoomLinkUrl,
                    TransJerashDormSingleRoomLinkUrl = collection.TransJerashDormSingleRoomLinkUrl,
                    TransAmmonDormSingleRoomTitle = collection.TransAmmonDormSingleRoomTitle,
                    TransAmmonDormSingleRoomBrief = collection.TransAmmonDormSingleRoomBrief,



                    IsActive = true,
                    IsDelete = false,

                    MasterDormId = collection.MasterDormId,
                    //LookupCategoryMenu = LookupCategoryMenu.Find(collection.LookupCategoryMenuId),
                    TransJerashDormSingleRoomImage = FileImge1,
                    TransAmmonDormSingleRoomImage = FileImge2,
                };
                TransInternationalDormSingleRoom.Add(obj3);
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
            var data = TransInternationalDormSingleRoom.Find(id);
            VM_TransInternationalDormSingleRoom obj4 = new VM_TransInternationalDormSingleRoom();
            obj4.TransInternationalDormSingleRoomId = data.TransInternationalDormSingleRoomId;
            obj4.TransJarashDormSingleRoomTitle = data.TransJarashDormSingleRoomTitle;
            obj4.TransJerashDormSingleRoomBrief = data.TransJerashDormSingleRoomBrief;
            obj4.TransJerashDormSingleRoomImage = data.TransJerashDormSingleRoomImage;
            obj4.TransJerashDormSingleRoomLinkUrl = data.TransJerashDormSingleRoomLinkUrl;
            obj4.TransAmmonDormSingleRoomTitle = data.TransAmmonDormSingleRoomTitle;
            obj4.TransAmmonDormSingleRoomBrief = data.TransAmmonDormSingleRoomBrief;
            obj4.TransAmmonDormSingleRoomImage = data.TransAmmonDormSingleRoomImage;
            obj4.TransAmmonDormSingleRoomLinkUrl = data.TransAmmonDormSingleRoomLinkUrl;
            obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);

            obj4.ListMasterDorm = MasterDorm.View();

            return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_TransInternationalDormSingleRoom collection)
        {
            try
            {

                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Jerash);
                FileImge1 = SaveImage(collection.File_Ammon);
                TransInternationalDormSingleRoom obj5 = new TransInternationalDormSingleRoom
                {
                    TransInternationalDormSingleRoomId = collection.TransInternationalDormSingleRoomId,
                    TransJarashDormSingleRoomTitle = collection.TransJarashDormSingleRoomTitle,
                    TransJerashDormSingleRoomBrief = collection.TransJerashDormSingleRoomBrief,
                    TransAmmonDormSingleRoomLinkUrl = collection.TransAmmonDormSingleRoomLinkUrl,
                    TransJerashDormSingleRoomLinkUrl = collection.TransJerashDormSingleRoomLinkUrl,
                    TransAmmonDormSingleRoomTitle = collection.TransAmmonDormSingleRoomTitle,
                    TransAmmonDormSingleRoomBrief = collection.TransAmmonDormSingleRoomBrief,
                    IsActive = true,
                    IsDelete = false,

                    MasterDorm = MasterDorm.Find(collection.MasterDormId),
                    TransAmmonDormSingleRoomImage = (FileImge1 == "" ? collection.TransJerashDormSingleRoomImage : FileImge1),
                    TransJerashDormSingleRoomImage = (FileImge2 == "" ? collection.TransJerashDormSingleRoomImage : FileImge2),

                    //LookupProductImageUrl = FileImge,
                };
                TransInternationalDormSingleRoom.Update(id, obj5);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransInnerDormDoubleRoomController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = TransInternationalDormSingleRoom.Find(id);
            data.IsDelete = true;
            TransInternationalDormSingleRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
        }

        // POST: TransInnerDormDoubleRoomController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, TransInternationalDormSingleRoom collection)
        //{
        //    try
        //    {
        //        var data = TransInternationalDormSingleRoom.Find(id);
        //        data.IsDelete = true;
        //        TransInternationalDormSingleRoom.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = TransInternationalDormSingleRoom.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            TransInternationalDormSingleRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                Guid obj = Guid.NewGuid(); 
                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/TransInternationalDormSingleRoom");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + obj + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;
        }
    }
}
