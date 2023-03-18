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
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace SystemWebDorms.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class MasterDormController : Controller
    {
        public InterfaceSystemWebDorms<MasterDorm> MasterDorm { get; }
        public IHostingEnvironment Hosting { get; }

        public MasterDormController(InterfaceSystemWebDorms<MasterDorm> _MasterDorm,IHostingEnvironment hosting)
        {
            MasterDorm = _MasterDorm;
            Hosting = hosting;

        }
        // GET: MasterDormController

        public ActionResult Index()
        {
            List<MasterDorm> data = MasterDorm.View();
            return View(data);
        }

        // GET: MasterDormController/Details/5
        public ActionResult Details(int id)
        {
            var data = MasterDorm.Find(id);
            return View(data);
        }

        // GET: MasterDormController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterDormController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VM_MasterDorm collection)
        {
            try
            {
                string FileImge = "";

                FileImge = SaveImage(collection.File);
                MasterDorm obj = new MasterDorm()
                {
                    MasterDormId = collection.MasterDormId,
                    MasterDormName = collection.MasterDormName,
                    MasterDormBrief = collection.MasterDormBrief,
                    //MasterDormImage = collection.MasterDormImage,
                    MasterDormLinkUrl = collection.MasterDormLinkUrl,
                    MasterDormLinkMap = collection.MasterDormLinkMap,
                    IsActive = true,
                    IsDelete = false,
                    MasterDormImage = FileImge,


                };
                MasterDorm.Add(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterDormController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterDorm.Find(id);

            VM_MasterDorm obj1 = new VM_MasterDorm();
            obj1.MasterDormId = data.MasterDormId;
            obj1.MasterDormBrief = data.MasterDormBrief;
            obj1.MasterDormLinkMap = data.MasterDormLinkMap;
            obj1.MasterDormLinkUrl = data.MasterDormLinkUrl;
            obj1.MasterDormName = data.MasterDormName;
            obj1.MasterDormImage = data.MasterDormImage;


            return View(obj1);
        }

        // POST: MasterDormController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_MasterDorm collection)
        {
            try
            {
                string FileImge = "";

                FileImge = SaveImage(collection.File);
                MasterDorm obj = new MasterDorm()
                {
                    MasterDormId = collection.MasterDormId,
                    MasterDormName = collection.MasterDormName,
                    MasterDormBrief = collection.MasterDormBrief,
                    //MasterDormImage = collection.MasterDormImage,
                    MasterDormLinkUrl = collection.MasterDormLinkUrl,
                    MasterDormLinkMap = collection.MasterDormLinkMap,
                    IsActive = true,
                    IsDelete = false,
                    //MasterDormImage = FileImge,
                    MasterDormImage = (FileImge == "" ? collection.MasterDormImage : FileImge),


                };
                MasterDorm.Update(id, obj);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterDormController/Delete/5
        public ActionResult Delete(int id , MasterDorm collection)
        {
            var data = MasterDorm.Find(id);
            data.IsDelete = true;
                    MasterDorm.Update(id, data);
                    return RedirectToAction(nameof(Index));
        }

        // POST: MasterDormController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, MasterDorm collection)
        //{
        //    try
        //    {
        //        var data = MasterDorm.Find(id);
        //        data.IsDelete = true;
        //        MasterDorm.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = MasterDorm.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            MasterDorm.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/MasterDorm");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;
        }
    }
}
