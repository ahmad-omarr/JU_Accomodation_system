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

    public class TransContactUsController : Controller
    {
        public InterfaceSystemWebDorms<TransContactUs> TransContactUs { get; }
        public IHostingEnvironment Hosting { get; }

        public TransContactUsController(InterfaceSystemWebDorms<TransContactUs> _TransContactUs, IHostingEnvironment _hosting)
        {
            TransContactUs = _TransContactUs;
            Hosting = _hosting;
        }
        // GET: MasterOfferController
        public ActionResult Index()
        {
            var data = TransContactUs.View();

            return View(data);
        }

        // GET: MasterOfferController/Details/5
        public ActionResult Details(int id)
        {
            var data = TransContactUs.Find(id);
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
        public ActionResult Create(VM_TransContactUs collection)
        {
            string FileImge = "";

            FileImge = SaveImage(collection.File);
            try
            {
                TransContactUs obj3 = new TransContactUs
                {
                    TransContactUsId = collection.TransContactUsId,
                    TransContactLinkUrl = collection.TransContactLinkUrl,
                    TransContactUsDiscrption = collection.TransContactUsDiscrption,
                    TransContactUsFirstName = collection.TransContactUsFirstName,
                    TransContactUsLastName = collection.TransContactUsLastName,
                    TransContactUsTitle = collection.TransContactUsTitle,
                    TransContactUsStudentNumber = collection.TransContactUsStudentNumber,
                    


                    IsActive = true,
                    IsDelete = false,

                    TransContactUrlImage = FileImge
                };
                TransContactUs.Add(obj3);
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
            var data = TransContactUs.Find(id);

            VM_TransContactUs obj1 = new VM_TransContactUs();
            obj1.TransContactUsId = data.TransContactUsId;
            obj1.TransContactLinkUrl = data.TransContactLinkUrl;
            obj1.TransContactUsDiscrption = data.TransContactUsDiscrption;
            obj1.TransContactUsFirstName = data.TransContactUsFirstName;
            obj1.TransContactUsLastName = data.TransContactUsLastName;
            obj1.TransContactUsTitle = data.TransContactUsTitle;
            obj1.TransContactUsStudentNumber = data.TransContactUsStudentNumber;

            obj1.TransContactUrlImage = data.TransContactUrlImage;

            return View(obj1);
        }

        // POST: MasterOfferController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_TransContactUs collection)
        {
            try
            {
                string FileImge = "";

                FileImge = SaveImage(collection.File);
                TransContactUs obj3 = new TransContactUs
                {
                    TransContactUsId = collection.TransContactUsId,
                    TransContactLinkUrl = collection.TransContactLinkUrl,
                    TransContactUsDiscrption = collection.TransContactUsDiscrption,
                    TransContactUsFirstName = collection.TransContactUsFirstName,
                    TransContactUsLastName = collection.TransContactUsLastName,
                    TransContactUsTitle = collection.TransContactUsTitle,
                    TransContactUsStudentNumber = collection.TransContactUsStudentNumber,

                    IsActive = true,
                    IsDelete = false,

                    TransContactUrlImage = (FileImge == "" ? collection.TransContactUrlImage : FileImge)
                };
                TransContactUs.Update(id, obj3);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterOfferController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = TransContactUs.Find(id);
            return View(data);
        }

        // POST: MasterOfferController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TransContactUs collection)
        {
            try
            {
                var data = TransContactUs.Find(id);
                data.IsDelete = true;

                TransContactUs.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Active(int id)
        {
            var data = TransContactUs.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            TransContactUs.Update(id, data);
            return RedirectToAction(nameof(Index));
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
