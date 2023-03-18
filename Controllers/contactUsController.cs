using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SystemWebDorms.Models;
using SystemWebDorms.Models.Repositories;
using SystemWebDorms.ViewModels;

namespace SystemWebDorms.Controllers
{
    public class contactUsController : Controller
    {
        public InterfaceSystemWebDorms<SystemSetting> SystemSetting { get; }
        public InterfaceSystemWebDorms<MasterSocialMedium> ListMasterSocialMedium { get; }
        public InterfaceSystemWebDorms<MasterMenu> ListMasterMenu { get; }
        public InterfaceSystemWebDorms<TransContactUs> TransContactUs { get; }
        public IHostingEnvironment Hosting { get; }

        public contactUsController(InterfaceSystemWebDorms<SystemSetting> _SystemSetting,
            InterfaceSystemWebDorms<MasterSocialMedium> _ListMasterSocialMedium,
        InterfaceSystemWebDorms<MasterMenu> _ListMasterMenu,
        InterfaceSystemWebDorms<TransContactUs> _TransContactUs,
         IHostingEnvironment _hosting)
        {
            SystemSetting = _SystemSetting;
            ListMasterSocialMedium = _ListMasterSocialMedium;
            ListMasterMenu = _ListMasterMenu;
            TransContactUs = _TransContactUs;
            Hosting = _hosting;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            VM_Front obj = new VM_Front
            {
                ListMasterSocialMedium = ListMasterSocialMedium.ViewClient(),
                SystemSetting = SystemSetting.ViewClient().OrderByDescending(x => x.SystemSettingId).FirstOrDefault(),
                ListMasterMenu = ListMasterMenu.ViewClient(),
            };
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BBB(VM_Front collection)
        {
            //string FileImge = "";

            //FileImge = SaveImage(collection.TransContactUs.File);
            try
            {
                //    TransContactUs obj3 = new TransContactUs
                //    {
                //        TransContactUsId = collection.TransContactUsId,
                //        TransContactLinkUrl = collection.TransContactLinkUrl,
                //        TransContactUsDiscrption = collection.TransContactUsDiscrption,
                //        TransContactUsFirstName = collection.TransContactUsFirstName,
                //        TransContactUsLastName = collection.TransContactUsLastName,
                //        TransContactUsTitle = collection.TransContactUsTitle,
                //        TransContactUsStudentNumber = collection.TransContactUsStudentNumber,



                //        IsActive = true,
                //        IsDelete = false,

                //collection.TransContactUs.TransContactUrlImage = FileImge;
                //    };
                //    TransContactUs.Add(obj3);
                collection.TransContactUs.IsActive = true;
                collection.TransContactUs.IsDelete = false;
                TransContactUs.Add(collection.TransContactUs);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/TransContactUs");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;

        }
    }
    
}
