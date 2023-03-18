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
    public class SystemSettingController : Controller
    {
        public InterfaceSystemWebDorms<SystemSetting> SystemSetting { get; }
        public IHostingEnvironment Hosting { get; }

        public SystemSettingController(InterfaceSystemWebDorms<SystemSetting> _SystemSetting, IHostingEnvironment _hosting)
        {
            SystemSetting = _SystemSetting;
            Hosting = _hosting;
        }
        // GET: MasterOfferController
        public ActionResult Index()
        {
            var data = SystemSetting.View();

            return View(data);
        }

        // GET: MasterOfferController/Details/5
        public ActionResult Details(int id)
        {
            var data = SystemSetting.Find(id);
            return View(data);
        }

        // GET: MasterOfferController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterOfferController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VM_SystemSetting collection)
        {
            string FileImge1 = "";
            string FileImge2 = "";


            FileImge1 = SaveImage(collection.File_LogoNav);
            FileImge2 = SaveImage(collection.File_LogoFooter);

            try
            {
                SystemSetting obj3 = new SystemSetting
                {
                    SystemSettingId = collection.SystemSettingId,
                    SystemSettingAmmonDorm = collection.SystemSettingAmmonDorm,
                    SystemSettingAndalusDorm = collection.SystemSettingAndalusDorm,
                    SystemSettingBriefDorm = collection.SystemSettingBriefDorm,
                    SystemSettingBriefFooter = collection.SystemSettingBriefFooter,
                    SystemSettingJerashDorm = collection.SystemSettingJerashDorm,
                    SystemSettingTitleDorm = collection.SystemSettingTitleDorm,
                    SystemSettingZahraaDorm = collection.SystemSettingZahraaDorm,
                   

                    IsActive = true,
                    IsDelete = false,

                    SystemSettingLogoFooter = FileImge1,
                    SystemSettingLogoNav = FileImge2,
                };
                SystemSetting.Add(obj3);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterOfferController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = SystemSetting.Find(id);

            VM_SystemSetting obj1 = new VM_SystemSetting();
            obj1.SystemSettingId = data.SystemSettingId;
            obj1.SystemSettingLogoNav = data.SystemSettingLogoNav;
            obj1.SystemSettingLogoFooter = data.SystemSettingLogoFooter;
            obj1.SystemSettingAmmonDorm = data.SystemSettingAmmonDorm;
            obj1.SystemSettingAndalusDorm = data.SystemSettingAndalusDorm;
            obj1.SystemSettingBriefDorm = data.SystemSettingBriefDorm;
            obj1.SystemSettingBriefFooter = data.SystemSettingBriefFooter;
            obj1.SystemSettingJerashDorm = data.SystemSettingJerashDorm;
            obj1.SystemSettingZahraaDorm = data.SystemSettingZahraaDorm;
            obj1.SystemSettingTitleDorm = data.SystemSettingTitleDorm;

            return View(obj1);
        }

        // POST: MasterOfferController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_SystemSetting collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_LogoNav);
                FileImge2 = SaveImage(collection.File_LogoFooter);
                SystemSetting obj3 = new SystemSetting
                {
                    SystemSettingId = collection.SystemSettingId,
                    SystemSettingAmmonDorm = collection.SystemSettingAmmonDorm,
                    SystemSettingAndalusDorm = collection.SystemSettingAndalusDorm,
                    SystemSettingBriefDorm = collection.SystemSettingBriefDorm,
                    SystemSettingBriefFooter = collection.SystemSettingBriefFooter,
                    SystemSettingJerashDorm = collection.SystemSettingJerashDorm,
                    SystemSettingTitleDorm = collection.SystemSettingTitleDorm,
                    SystemSettingZahraaDorm = collection.SystemSettingZahraaDorm,

                    IsActive = true,
                    IsDelete = false,
                    SystemSettingLogoNav = (FileImge2 == "" ? collection.SystemSettingLogoNav : FileImge2),

                    SystemSettingLogoFooter = (FileImge1 == "" ? collection.SystemSettingLogoFooter : FileImge1),

                };
                SystemSetting.Update(id, obj3);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterOfferController/Delete/5
        public ActionResult Delete(int id , SystemSetting collection)
        {
            var data = SystemSetting.Find(id);
            data.IsDelete = true;

            SystemSetting.Update(id, data);
            return RedirectToAction(nameof(Index));
        }

        // POST: MasterOfferController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, SystemSetting collection)
        //{
        //    try
        //    {
        //        var data = SystemSetting.Find(id);
        //        data.IsDelete = true;

        //        SystemSetting.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = SystemSetting.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            SystemSetting.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                Guid obj = Guid.NewGuid();
                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/SystemSetting");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + obj + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;

        }
    }
}
