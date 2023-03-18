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
    public class TransInternationalDormDoubleRoomSisterController : Controller
    {
        public InterfaceSystemWebDorms<MasterDorm> MasterDorm { get; }
        public IHostingEnvironment Hosting { get; }
        public InterfaceSystemWebDorms<TransInternationalDormDoubleRoomSister> TransInternationalDormDoubleRoomSister { get; }

        public TransInternationalDormDoubleRoomSisterController(InterfaceSystemWebDorms<TransInternationalDormDoubleRoomSister> _TransInternationalDormDoubleRoomSister, InterfaceSystemWebDorms<MasterDorm> _MasterDorm, IHostingEnvironment hosting)
        {
            MasterDorm = _MasterDorm;
            Hosting = hosting;
            TransInternationalDormDoubleRoomSister = _TransInternationalDormDoubleRoomSister;

        }
        // GET: TransInnerDormDoubleRoomController
        public ActionResult Index()
        {
            var data = TransInternationalDormDoubleRoomSister.View();

            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Details/5
        public ActionResult Details(int id)
        {
            var data = TransInternationalDormDoubleRoomSister.Find(id);
            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Create
        public ActionResult Create()
        {
            VM_TransInternationalDormDoubleRoomSister obj2 = new VM_TransInternationalDormDoubleRoomSister
            {
                ListMasterDorm = MasterDorm.View()
            };
            return View(obj2);
        }

        // POST: TransInnerDormDoubleRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VM_TransInternationalDormDoubleRoomSister collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Jerash);
                FileImge2 = SaveImage(collection.File_Ammon );
                TransInternationalDormDoubleRoomSister obj3 = new TransInternationalDormDoubleRoomSister
                {
                    TransInternationalDormDoubleRoomSisterId = collection.TransInternationalDormDoubleRoomSisterId,
                    TransJarashDormDoubleRoomSistersTitle  = collection.TransJarashDormDoubleRoomSistersTitle,
                    TransJerashDormDoubleRoomSistersBrief  = collection.TransJerashDormDoubleRoomSistersBrief,
                    TransAmmonDormDoubleRoomSistersLinkUrl = collection.TransAmmonDormDoubleRoomSistersLinkUrl,
                    TransJerashDormDoubleRoomSistersLinkUrl  = collection.TransJerashDormDoubleRoomSistersLinkUrl,
                    TransAmmonDormDoubleRoomSistersTitle   = collection.TransAmmonDormDoubleRoomSistersTitle ,
                    TransAmmonDormDoubleRoomSistersBrief   = collection.TransAmmonDormDoubleRoomSistersBrief,

                    IsActive = true,
                    IsDelete = false,

                    MasterDormId = collection.MasterDormId,
                    //LookupCategoryMenu = LookupCategoryMenu.Find(collection.LookupCategoryMenuId),
                    TransJerashDormDoubleRoomSistersImage = FileImge1,
                    TransAmmonDormDoubleRoomSistersImage = FileImge2,
                };
                TransInternationalDormDoubleRoomSister.Add(obj3);
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
            var data = TransInternationalDormDoubleRoomSister.Find(id);
            VM_TransInternationalDormDoubleRoomSister obj4 = new VM_TransInternationalDormDoubleRoomSister();
            obj4.TransInternationalDormDoubleRoomSisterId = data.TransInternationalDormDoubleRoomSisterId;
            obj4.TransJarashDormDoubleRoomSistersTitle = data.TransJarashDormDoubleRoomSistersTitle;
            obj4.TransJerashDormDoubleRoomSistersBrief = data.TransJerashDormDoubleRoomSistersBrief;
            obj4.TransAmmonDormDoubleRoomSistersLinkUrl = data.TransAmmonDormDoubleRoomSistersLinkUrl;
            obj4.TransJerashDormDoubleRoomSistersLinkUrl = data.TransJerashDormDoubleRoomSistersLinkUrl;
            obj4.TransAmmonDormDoubleRoomSistersTitle = data.TransAmmonDormDoubleRoomSistersTitle;
            obj4.TransAmmonDormDoubleRoomSistersBrief = data.TransAmmonDormDoubleRoomSistersBrief;
            obj4.TransJerashDormDoubleRoomSistersImage = data.TransJerashDormDoubleRoomSistersImage;
            obj4.TransAmmonDormDoubleRoomSistersImage = data.TransAmmonDormDoubleRoomSistersImage;
            obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);

            obj4.ListMasterDorm = MasterDorm.View();

            return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_TransInternationalDormDoubleRoomSister collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Jerash);
                FileImge2 = SaveImage(collection.File_Ammon);
                TransInternationalDormDoubleRoomSister obj5 = new TransInternationalDormDoubleRoomSister
                {
                    TransInternationalDormDoubleRoomSisterId = collection.TransInternationalDormDoubleRoomSisterId,
                    TransJarashDormDoubleRoomSistersTitle = collection.TransJarashDormDoubleRoomSistersTitle,
                    TransJerashDormDoubleRoomSistersBrief = collection.TransJerashDormDoubleRoomSistersBrief,
                    TransAmmonDormDoubleRoomSistersLinkUrl = collection.TransAmmonDormDoubleRoomSistersLinkUrl,
                    TransJerashDormDoubleRoomSistersLinkUrl = collection.TransJerashDormDoubleRoomSistersLinkUrl,
                    TransAmmonDormDoubleRoomSistersTitle = collection.TransAmmonDormDoubleRoomSistersTitle,
                    TransAmmonDormDoubleRoomSistersBrief = collection.TransAmmonDormDoubleRoomSistersBrief,

                    IsActive = true,
                    IsDelete = false,

                    MasterDormId = collection.MasterDormId,
                    TransAmmonDormDoubleRoomSistersImage = (FileImge1 == "" ? collection.TransAmmonDormDoubleRoomSistersImage : FileImge1),
                    TransJerashDormDoubleRoomSistersImage = (FileImge2 == "" ? collection.TransJerashDormDoubleRoomSistersImage : FileImge2),

                    //LookupProductImageUrl = FileImge,
                };
                TransInternationalDormDoubleRoomSister.Update(id, obj5);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransInnerDormDoubleRoomController/Delete/5
        public ActionResult Delete(int id, TransInternationalDormDoubleRoomSister collection)
        {
            var data = TransInternationalDormDoubleRoomSister.Find(id);
            data.IsDelete = true;
            TransInternationalDormDoubleRoomSister.Update(id, data);
            return RedirectToAction(nameof(Index));
        }

        // POST: TransInnerDormDoubleRoomController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, TransInternationalDormDoubleRoomSister collection)
        //{
        //    try
        //    {
        //        var data = TransInternationalDormDoubleRoomSister.Find(id);
        //        data.IsDelete = true;
        //        TransInternationalDormDoubleRoomSister.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = TransInternationalDormDoubleRoomSister.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            TransInternationalDormDoubleRoomSister.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                Guid obj = Guid.NewGuid();

                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/TransInternationalDormDoubleRoomSister");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + obj + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;
        }
    }
}
