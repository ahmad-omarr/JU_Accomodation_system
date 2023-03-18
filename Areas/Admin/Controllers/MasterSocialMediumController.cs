using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemWebDorms.Models;
using SystemWebDorms.Models.Repositories;

namespace SystemWebDorms.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class MasterSocialMediumController : Controller
    {
        public InterfaceSystemWebDorms<MasterSocialMedium> MasterSocialMedium { get; }

        public MasterSocialMediumController(InterfaceSystemWebDorms<MasterSocialMedium> _MasterSocialMedium)
        {
            MasterSocialMedium = _MasterSocialMedium;
            
        }
        // GET: MasterWorkingHourController
        public ActionResult Index()
        {
            List<MasterSocialMedium> data = MasterSocialMedium.View();
            return View(data);
        }

        // GET: MasterWorkingHourController/Details/5
        public ActionResult Details(int id)
        {
            var data = MasterSocialMedium.Find(id);
            return View(data);
        }

        // GET: MasterWorkingHourController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterWorkingHourController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterSocialMedium collection)
        {
            try
            {
                MasterSocialMedium obj = new MasterSocialMedium()
                {
                    MasterSocialMediumId = collection.MasterSocialMediumId,
                    MasterSocialMediaName = collection.MasterSocialMediaName,
                    MasterSocialMediaIconUrl = collection.MasterSocialMediaIconUrl,
                    MasterSocialMediaLinkUrl = collection.MasterSocialMediaLinkUrl,
                    IsActive = true,
                    IsDelete = false,
                    
                };
                MasterSocialMedium.Add(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterWorkingHourController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterSocialMedium.Find(id);
            return View(data);
        }

        // POST: MasterWorkingHourController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterSocialMedium collection)
        {
            try
            {
                MasterSocialMedium obj = new MasterSocialMedium()
                {
                    MasterSocialMediumId = collection.MasterSocialMediumId,
                    MasterSocialMediaName = collection.MasterSocialMediaName,
                    MasterSocialMediaIconUrl = collection.MasterSocialMediaIconUrl,
                    MasterSocialMediaLinkUrl = collection.MasterSocialMediaLinkUrl,
                    IsActive = true,
                    IsDelete = false,
                   
                };
                MasterSocialMedium.Update(id, obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterWorkingHourController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = MasterSocialMedium.Find(id);
            data.IsDelete = true;
            MasterSocialMedium.Update(id, data);
            return RedirectToAction(nameof(Index));
        }

        // POST: MasterWorkingHourController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, MasterSocialMedium collection)
        //{
        //    try
        //    {
        //        var data = MasterSocialMedium.Find(id);
        //        data.IsDelete = true;
        //        MasterSocialMedium.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = MasterSocialMedium.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }
            MasterSocialMedium.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
    }
}
