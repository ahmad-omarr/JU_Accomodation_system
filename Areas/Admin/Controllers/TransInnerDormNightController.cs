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
    public class TransInnerDormNightController : Controller
    {
        public InterfaceSystemWebDorms<MasterDorm> MasterDorm { get; }
        public IHostingEnvironment Hosting { get; }
        public InterfaceSystemWebDorms<TransInnerDormNight> TransInnerDormNight { get; }

        public TransInnerDormNightController(InterfaceSystemWebDorms<TransInnerDormNight> _TransInnerDormNight, InterfaceSystemWebDorms<MasterDorm> _MasterDorm, IHostingEnvironment hosting)
        {
            MasterDorm = _MasterDorm;
            Hosting = hosting;
            TransInnerDormNight = _TransInnerDormNight;

        }
        // GET: TransInnerDormDoubleRoomController
        public ActionResult Index()
        {
            var data = TransInnerDormNight.View();

            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Details/5
        public ActionResult Details(int id)
        {
            var data = TransInnerDormNight.Find(id);
            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Create
        public ActionResult Create()
        {
            VM_TransInnerDormNight obj2 = new VM_TransInnerDormNight
            {
                ListMasterDorm = MasterDorm.View()
            };
            return View(obj2);
        }

        // POST: TransInnerDormDoubleRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VM_TransInnerDormNight collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Andalus);
                FileImge2 = SaveImage(collection.File_Zahraa);

                TransInnerDormNight obj3 = new TransInnerDormNight
                {
                    TransInnerDormNightId = collection.TransInnerDormNightId,
                    TransZahraaDormNightRoomTitle = collection.TransZahraaDormNightRoomTitle,
                    TransZahraaDormNightRoomBrief = collection.TransZahraaDormNightRoomBrief,
                    TransAndalusDormNightRoomLinkUrl = collection.TransAndalusDormNightRoomLinkUrl,
                    TransZahraaDormNightRoomLinkUrl = collection.TransZahraaDormNightRoomLinkUrl,
                    TransAndalusDormNightRoomTitle = collection.TransAndalusDormNightRoomTitle,
                    TransAndalusDormNightRoomBrief = collection.TransAndalusDormNightRoomBrief,


                    IsActive = true,
                    IsDelete = false,

                    MasterDormId = collection.MasterDormId,
                    TransAndalusDormNightRoomImage = FileImge1,
                    TransZahraaDormNightRoomImage = FileImge2,
                };
                TransInnerDormNight.Add(obj3);
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
            var data = TransInnerDormNight.Find(id);
            VM_TransInnerDormNight obj4 = new VM_TransInnerDormNight();
            obj4.TransInnerDormNightId = data.TransInnerDormNightId;
            obj4.TransZahraaDormNightRoomTitle = data.TransZahraaDormNightRoomTitle;
            obj4.TransZahraaDormNightRoomBrief = data.TransZahraaDormNightRoomBrief;
            obj4.TransZahraaDormNightRoomImage = data.TransZahraaDormNightRoomImage;
            obj4.TransZahraaDormNightRoomLinkUrl = data.TransZahraaDormNightRoomLinkUrl;
            obj4.TransAndalusDormNightRoomTitle = data.TransAndalusDormNightRoomTitle;
            obj4.TransAndalusDormNightRoomBrief = data.TransAndalusDormNightRoomBrief;
            obj4.TransAndalusDormNightRoomImage = data.TransAndalusDormNightRoomImage;
            obj4.TransAndalusDormNightRoomLinkUrl = data.TransAndalusDormNightRoomLinkUrl;
            obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);

            obj4.ListMasterDorm = MasterDorm.View();

            return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_TransInnerDormNight collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Andalus);
                FileImge2 = SaveImage(collection.File_Zahraa);
                TransInnerDormNight obj5 = new TransInnerDormNight
                {
                    TransInnerDormNightId = collection.TransInnerDormNightId,
                    TransZahraaDormNightRoomTitle = collection.TransZahraaDormNightRoomTitle,
                    TransZahraaDormNightRoomBrief = collection.TransZahraaDormNightRoomBrief,
                    TransAndalusDormNightRoomLinkUrl = collection.TransAndalusDormNightRoomLinkUrl,
                    TransZahraaDormNightRoomLinkUrl = collection.TransZahraaDormNightRoomLinkUrl,
                    TransAndalusDormNightRoomTitle = collection.TransAndalusDormNightRoomTitle,
                    TransAndalusDormNightRoomBrief = collection.TransAndalusDormNightRoomBrief,

                    IsActive = true,
                    IsDelete = false,

                    MasterDorm = MasterDorm.Find(collection.MasterDormId),
                    TransZahraaDormNightRoomImage = (FileImge1 == "" ? collection.TransZahraaDormNightRoomImage : FileImge1),
                    TransAndalusDormNightRoomImage = (FileImge2 == "" ? collection.TransAndalusDormNightRoomImage : FileImge2),

                };
                TransInnerDormNight.Update(id, obj5);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransInnerDormDoubleRoomController/Delete/5
        public ActionResult Delete(int id, TransInnerDormNight collection)
        {
            var data = TransInnerDormNight.Find(id);
            data.IsDelete = true;
            TransInnerDormNight.Update(id, data);
            return RedirectToAction(nameof(Index));
        }

        // POST: TransInnerDormDoubleRoomController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, TransInnerDormNight collection)
        //{
        //    try
        //    {
        //        var data = TransInnerDormNight.Find(id);
        //        data.IsDelete = true;
        //        TransInnerDormNight.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = TransInnerDormNight.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            TransInnerDormNight.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                Guid obj =  Guid.NewGuid();
                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/TransInnerDormNight");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + obj + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;
        }
    }
}
