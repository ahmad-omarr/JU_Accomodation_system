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

    public class TransInnerDormTripleRoomController : Controller

    {
        public InterfaceSystemWebDorms<MasterDorm> MasterDorm { get; }
        public IHostingEnvironment Hosting { get; }
        public InterfaceSystemWebDorms<TransInnerDormTripleRoom> TransInnerDormTripleRoom { get; }

        public TransInnerDormTripleRoomController(InterfaceSystemWebDorms<TransInnerDormTripleRoom> _TransInnerDormTripleRoom, InterfaceSystemWebDorms<MasterDorm> _MasterDorm, IHostingEnvironment hosting)
        {
            MasterDorm = _MasterDorm;
            Hosting = hosting;
            TransInnerDormTripleRoom = _TransInnerDormTripleRoom;

        }
        // GET: TransInnerDormDoubleRoomController
        public ActionResult Index()
        {
            var data = TransInnerDormTripleRoom.View();

            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Details/5
        public ActionResult Details(int id)
        {
            var data = TransInnerDormTripleRoom.Find(id);
            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Create
        public ActionResult Create()
        {
            VM_TransInnerDormTripleRoom obj2 = new VM_TransInnerDormTripleRoom
            {
                ListMasterDorm = MasterDorm.View()
            };
            return View(obj2);
        }

        // POST: TransInnerDormDoubleRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VM_TransInnerDormTripleRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Andalus);
                FileImge2 = SaveImage(collection.File_Zahraa);

                TransInnerDormTripleRoom obj3 = new TransInnerDormTripleRoom
                {
                    TransInnerDormTripleRoomId = collection.TransInnerDormTripleRoomId,
                    TransZahraaDormTripleRoomTitle = collection.TransZahraaDormTripleRoomTitle,
                    TransZahraaDormTripleRoomBrief = collection.TransZahraaDormTripleRoomBrief,
                    TransAndalusDormTripleRoomLinkUrl = collection.TransAndalusDormTripleRoomLinkUrl,
                    TransZahraaDormTripleRoomLinkUrl = collection.TransZahraaDormTripleRoomLinkUrl,
                    TransAndalusDormTripleRoomTitle = collection.TransAndalusDormTripleRoomTitle,
                    TransAndalusDormTripleRoomBrief = collection.TransAndalusDormTripleRoomBrief,


                    IsActive = true,
                    IsDelete = false,

                    MasterDormId = collection.MasterDormId,
                    //LookupCategoryMenu = LookupCategoryMenu.Find(collection.LookupCategoryMenuId),
                    TransAndalusDormTripleRoomImage = FileImge1,
                    TransZahraaDormTripleRoomImage = FileImge2,
                };
                TransInnerDormTripleRoom.Add(obj3);
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
            var data = TransInnerDormTripleRoom.Find(id);
            VM_TransInnerDormTripleRoom obj4 = new VM_TransInnerDormTripleRoom();
            obj4.TransInnerDormTripleRoomId = data.TransInnerDormTripleRoomId;
            obj4.TransZahraaDormTripleRoomTitle = data.TransZahraaDormTripleRoomTitle;
            obj4.TransZahraaDormTripleRoomBrief = data.TransZahraaDormTripleRoomBrief;
            obj4.TransZahraaDormTripleRoomImage = data.TransZahraaDormTripleRoomImage;
            obj4.TransZahraaDormTripleRoomLinkUrl = data.TransZahraaDormTripleRoomLinkUrl;
            obj4.TransAndalusDormTripleRoomTitle = data.TransAndalusDormTripleRoomTitle;
            obj4.TransAndalusDormTripleRoomBrief = data.TransAndalusDormTripleRoomBrief;
            obj4.TransAndalusDormTripleRoomImage = data.TransAndalusDormTripleRoomImage;
            obj4.TransAndalusDormTripleRoomLinkUrl = data.TransAndalusDormTripleRoomLinkUrl;
            obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);

            obj4.ListMasterDorm = MasterDorm.View();

            return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_TransInnerDormTripleRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Andalus);
                FileImge1 = SaveImage(collection.File_Zahraa);
                TransInnerDormTripleRoom obj5 = new TransInnerDormTripleRoom
                {
                    TransInnerDormTripleRoomId = collection.TransInnerDormTripleRoomId,
                    TransZahraaDormTripleRoomTitle = collection.TransZahraaDormTripleRoomTitle,
                    TransZahraaDormTripleRoomBrief = collection.TransZahraaDormTripleRoomBrief,
                    TransAndalusDormTripleRoomLinkUrl = collection.TransAndalusDormTripleRoomLinkUrl,
                    TransZahraaDormTripleRoomLinkUrl = collection.TransZahraaDormTripleRoomLinkUrl,
                    TransAndalusDormTripleRoomTitle = collection.TransAndalusDormTripleRoomTitle,
                    TransAndalusDormTripleRoomBrief = collection.TransAndalusDormTripleRoomBrief,

                    IsActive = true,
                    IsDelete = false,

                    MasterDorm = MasterDorm.Find(collection.MasterDormId),
                    TransZahraaDormTripleRoomImage = (FileImge1 == "" ? collection.TransZahraaDormTripleRoomImage : FileImge1),
                    TransAndalusDormTripleRoomImage = (FileImge2 == "" ? collection.TransAndalusDormTripleRoomImage : FileImge2),

                };
                TransInnerDormTripleRoom.Update(id, obj5);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransInnerDormDoubleRoomController/Delete/5
        public ActionResult Delete(int id, TransInnerDormTripleRoom collection)
        {
            var data = TransInnerDormTripleRoom.Find(id);
            data.IsDelete = true;
            TransInnerDormTripleRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
        }

        // POST: TransInnerDormDoubleRoomController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, TransInnerDormTripleRoom collection)
        //{
        //    try
        //    {
        //        var data = TransInnerDormTripleRoom.Find(id);
        //        data.IsDelete = true;
        //        TransInnerDormTripleRoom.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = TransInnerDormTripleRoom.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            TransInnerDormTripleRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                Guid obj = Guid.NewGuid();
                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/TransInnerDormTripleRoom");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + obj + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;
        }
    }
}
