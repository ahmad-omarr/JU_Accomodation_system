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
    public class TransInnerDormDoubleRoomController : Controller
    {

        public InterfaceSystemWebDorms<MasterDorm> MasterDorm { get; }
        public IHostingEnvironment Hosting { get; }
        public InterfaceSystemWebDorms<TransInnerDormDoubleRoom> TransInnerDormDoubleRoom { get; }

        public TransInnerDormDoubleRoomController(InterfaceSystemWebDorms<TransInnerDormDoubleRoom> _TransInnerDormDoubleRoom, InterfaceSystemWebDorms<MasterDorm> _MasterDorm, IHostingEnvironment hosting)
        {
            MasterDorm = _MasterDorm;
            Hosting = hosting;
            TransInnerDormDoubleRoom = _TransInnerDormDoubleRoom;

        }
        // GET: TransInnerDormDoubleRoomController
        public ActionResult Index()
        {
            var data = TransInnerDormDoubleRoom.View();

            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Details/5
        public ActionResult Details(int id)
        {
            var data = TransInnerDormDoubleRoom.Find(id);
            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Create
        public ActionResult Create()
        {
            VM_TransInnerDormDoubleRoom obj2 = new VM_TransInnerDormDoubleRoom
            {
                ListMasterDorm = MasterDorm.View()
            };  
            return View(obj2);
        }

        // POST: TransInnerDormDoubleRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VM_TransInnerDormDoubleRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Andalus);
                FileImge2 = SaveImage(collection.File_Zahraa);

                TransInnerDormDoubleRoom obj3 = new TransInnerDormDoubleRoom
                {
                    TransInnerDormDoubleRoomId = collection.TransInnerDormDoubleRoomId,
                    TransAndalusDormDoubleRoomTitle   = collection.TransAndalusDormDoubleRoomTitle,
                    TransAndalusDormDoubleRoomLinkUrl = collection.TransAndalusDormDoubleRoomLinkUrl,
                    TransAndalusDormDoubleRoomBrief   = collection.TransAndalusDormDoubleRoomBrief,
                    TransZahraaDormDoubleRoomBrief    = collection.TransZahraaDormDoubleRoomBrief,
                    TransZahraaDormDoubleRoomLinkUrl  = collection.TransZahraaDormDoubleRoomLinkUrl,
                    TransZahraaDormDoubleRoomTitle    = collection.TransZahraaDormDoubleRoomTitle,
                    
                    
                    
                    IsActive = true,
                    IsDelete = false,
                    
                    MasterDormId = collection.MasterDormId,
                    TransAndalusDormDoubleRoomImage = FileImge1,
                    TransZahraaDormDoubleRoomImage = FileImge2,
                };
                TransInnerDormDoubleRoom.Add(obj3);
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
            var data = TransInnerDormDoubleRoom.Find(id);
            VM_TransInnerDormDoubleRoom obj4 = new VM_TransInnerDormDoubleRoom();
            obj4.TransInnerDormDoubleRoomId = data.TransInnerDormDoubleRoomId;
            obj4.TransAndalusDormDoubleRoomTitle = data.TransAndalusDormDoubleRoomTitle;
            obj4.TransAndalusDormDoubleRoomLinkUrl= data.TransAndalusDormDoubleRoomLinkUrl;
            obj4.TransAndalusDormDoubleRoomBrief  = data.TransAndalusDormDoubleRoomBrief;
            obj4.TransZahraaDormDoubleRoomBrief   = data.TransZahraaDormDoubleRoomBrief;
            obj4.TransZahraaDormDoubleRoomLinkUrl = data.TransZahraaDormDoubleRoomLinkUrl;
            obj4.TransZahraaDormDoubleRoomTitle    = data.TransZahraaDormDoubleRoomTitle;
            obj4.TransAndalusDormDoubleRoomImage = data.TransAndalusDormDoubleRoomImage;
            obj4.TransZahraaDormDoubleRoomImage = data.TransZahraaDormDoubleRoomImage;
            obj4.ListMasterDorm = MasterDorm.View();

            obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);


            return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_TransInnerDormDoubleRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Andalus);
                FileImge2 = SaveImage(collection.File_Zahraa);

                TransInnerDormDoubleRoom obj5 = new TransInnerDormDoubleRoom
            {
                TransInnerDormDoubleRoomId = collection.TransInnerDormDoubleRoomId,
                TransAndalusDormDoubleRoomTitle = collection.TransAndalusDormDoubleRoomTitle,
                TransAndalusDormDoubleRoomLinkUrl = collection.TransAndalusDormDoubleRoomLinkUrl,
                TransAndalusDormDoubleRoomBrief = collection.TransAndalusDormDoubleRoomBrief,
                TransZahraaDormDoubleRoomBrief = collection.TransZahraaDormDoubleRoomBrief,
                TransZahraaDormDoubleRoomLinkUrl = collection.TransZahraaDormDoubleRoomLinkUrl,
                TransZahraaDormDoubleRoomTitle = collection.TransZahraaDormDoubleRoomTitle,
                IsActive = true,
                IsDelete = false,

                MasterDorm = MasterDorm.Find(collection.MasterDormId),
                TransZahraaDormDoubleRoomImage = (FileImge1 == "" ? collection.TransZahraaDormDoubleRoomImage : FileImge1),
                TransAndalusDormDoubleRoomImage = (FileImge2 == "" ? collection.TransAndalusDormDoubleRoomImage : FileImge2),

                //LookupProductImageUrl = FileImge,
            };
            TransInnerDormDoubleRoom.Update(id, obj5);

            return RedirectToAction(nameof(Index));
        }
            catch
            {
                return View();
            }
        }

        // GET: TransInnerDormDoubleRoomController/Delete/5
        public ActionResult Delete(int id, TransInnerDormDoubleRoom collection)
        {
            var data = TransInnerDormDoubleRoom.Find(id);
            data.IsDelete = true;
            TransInnerDormDoubleRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
            //var data = TransInnerDormDoubleRoom.Find(id);
            //VM_TransInnerDormDoubleRoom obj4 = new VM_TransInnerDormDoubleRoom();
            //obj4.TransInnerDormDoubleRoomId = data.TransInnerDormDoubleRoomId;
            //obj4.TransAndalusDormDoubleRoomTitle = data.TransAndalusDormDoubleRoomTitle;
            //obj4.TransAndalusDormDoubleRoomLinkUrl = data.TransAndalusDormDoubleRoomLinkUrl;
            //obj4.TransAndalusDormDoubleRoomBrief = data.TransAndalusDormDoubleRoomBrief;
            //obj4.TransZahraaDormDoubleRoomBrief = data.TransZahraaDormDoubleRoomBrief;
            //obj4.TransZahraaDormDoubleRoomLinkUrl = data.TransZahraaDormDoubleRoomLinkUrl;
            //obj4.TransZahraaDormDoubleRoomTitle = data.TransZahraaDormDoubleRoomTitle;
            //obj4.TransAndalusDormDoubleRoomImage = data.TransAndalusDormDoubleRoomImage;
            //obj4.TransZahraaDormDoubleRoomImage = data.TransZahraaDormDoubleRoomImage;
            //obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);

            //ViewBag.AA = MasterDorm.View();

            //return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, TransInnerDormDoubleRoom collection)
        //{
        //    try
        //    {
        //        var data = TransInnerDormDoubleRoom.Find(id);
        //        data.IsDelete = true;
        //        TransInnerDormDoubleRoom.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = TransInnerDormDoubleRoom.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            TransInnerDormDoubleRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                Guid obj = Guid.NewGuid();

                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/TransInnerDormDoubleRoom");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + obj + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;
        }
    }
}
