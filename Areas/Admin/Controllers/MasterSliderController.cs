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
    public class MasterSliderController : Controller
    {
        public InterfaceSystemWebDorms<MasterSlider> MasterSlider { get; }
        public IHostingEnvironment Hosting { get; }

        public MasterSliderController(InterfaceSystemWebDorms<MasterSlider> _MasterSlider, IHostingEnvironment _hosting)
        {
            MasterSlider = _MasterSlider;
            Hosting = _hosting;
        }
        // GET: MasterOfferController
        public ActionResult Index()
        {
            var data = MasterSlider.View();

            return View(data);
        }

        // GET: MasterOfferController/Details/5
        public ActionResult Details(int id)
        {
            var data = MasterSlider.Find(id);
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
        public ActionResult Create(VM_MasterSlider collection)
        {
            string FileImge = "";

            FileImge = SaveImage(collection.File);
            try
            {
                MasterSlider obj3 = new MasterSlider
                {
                    MasterSliderId = collection.MasterSliderId,
                    MasterSliderTitle = collection.MasterSliderTitle,
                    
                    
                    IsActive = true,
                    IsDelete = false,
                  
                    MasterSliderImageUrl = FileImge
                };
                MasterSlider.Add(obj3);
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
            var data = MasterSlider.Find(id);

            VM_MasterSlider obj1 = new VM_MasterSlider();
            obj1.MasterSliderId = data.MasterSliderId;
            obj1.MasterSliderTitle = data.MasterSliderTitle;
           
            obj1.MasterSliderImageUrl = data.MasterSliderImageUrl;
            
            return View(obj1);
        }

        // POST: MasterOfferController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_MasterSlider collection)
        {
            try
            {
                string FileImge = "";

                FileImge = SaveImage(collection.File);
                MasterSlider obj3 = new MasterSlider
                {
                    MasterSliderId = collection.MasterSliderId,
                    MasterSliderTitle = collection.MasterSliderTitle,
                    
                    IsActive = true,
                    IsDelete = false,
                    
                    MasterSliderImageUrl = (FileImge == "" ? collection.MasterSliderImageUrl : FileImge)
                };
                MasterSlider.Update(id, obj3);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterOfferController/Delete/5
        public ActionResult Delete(int id, MasterSlider collection)
        {
            var data = MasterSlider.Find(id);
            data.IsDelete = true;

            MasterSlider.Update(id, data);
            return RedirectToAction(nameof(Index));
        }

        // POST: MasterOfferController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, MasterSlider collection)
        //{
        //    try
        //    {
        //        var data = MasterSlider.Find(id);
        //        data.IsDelete = true;
              
        //        MasterSlider.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = MasterSlider.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }
            
            MasterSlider.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/MasterSlider");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;

        }
    }
}
