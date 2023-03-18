using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemWebDorms.Models;
using SystemWebDorms.Models.Repositories;
using SystemWebDorms.ViewModels;

namespace SystemWebDorms.Controllers
{

    public class HomeController : Controller
    {
        public InterfaceSystemWebDorms<SystemSetting> SystemSetting { get; }
        public InterfaceSystemWebDorms<MasterSlider> ListMasterSlider { get; }
        public InterfaceSystemWebDorms<MasterSocialMedium> ListMasterSocialMedium { get; }
        public InterfaceSystemWebDorms<MasterDorm> ListMasterDorm { get; }
        public InterfaceSystemWebDorms<MasterMenu> ListMasterMenu { get; }

        public HomeController(InterfaceSystemWebDorms<SystemSetting> _SystemSetting, 
            InterfaceSystemWebDorms<MasterSlider> _ListMasterSlider,
            InterfaceSystemWebDorms<MasterSocialMedium> _ListMasterSocialMedium,
            InterfaceSystemWebDorms<MasterDorm> _ListMasterDorm,
        InterfaceSystemWebDorms<MasterMenu> _ListMasterMenu)
        {
            SystemSetting = _SystemSetting;
            ListMasterSlider = _ListMasterSlider;
            ListMasterSocialMedium = _ListMasterSocialMedium;
            ListMasterDorm = _ListMasterDorm;
            ListMasterMenu = _ListMasterMenu;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            VM_Front obj = new VM_Front
            {
                ListMasterSlider = ListMasterSlider.ViewClient(),
                ListMasterSocialMedium = ListMasterSocialMedium.ViewClient(),
                SystemSetting = SystemSetting.ViewClient().OrderByDescending(x => x.SystemSettingId).FirstOrDefault(),
                ListMasterDorm = ListMasterDorm.ViewClient(),
                ListMasterMenu = ListMasterMenu.ViewClient(),
            };
            return View(obj);
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
