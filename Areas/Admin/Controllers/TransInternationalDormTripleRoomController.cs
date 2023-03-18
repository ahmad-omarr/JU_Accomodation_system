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
    public class TransInternationalDormTripleRoomController : Controller
    {
        public InterfaceSystemWebDorms<MasterDorm> MasterDorm { get; }
        public IHostingEnvironment Hosting { get; }
        public InterfaceSystemWebDorms<TransInternationalDormTripleRoom> TransInternationalDormTripleRoom { get; }

        public TransInternationalDormTripleRoomController(InterfaceSystemWebDorms<TransInternationalDormTripleRoom> _TransInternationalDormTripleRoom, InterfaceSystemWebDorms<MasterDorm> _MasterDorm, IHostingEnvironment hosting)
        {
            MasterDorm = _MasterDorm;
            Hosting = hosting;
            TransInternationalDormTripleRoom = _TransInternationalDormTripleRoom;

        }
        // GET: TransInnerDormDoubleRoomController
        public ActionResult Index()
        {
            var data = TransInternationalDormTripleRoom.View();

            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Details/5
        public ActionResult Details(int id)
        {
            var data = TransInternationalDormTripleRoom.Find(id);
            return View(data);
        }

        // GET: TransInnerDormDoubleRoomController/Create
        public ActionResult Create()
        {
            VM_TransInternationalDormTripleRoom obj2 = new VM_TransInternationalDormTripleRoom
            {
                ListMasterDorm = MasterDorm.View()
            };
            return View(obj2);
        }

        // POST: TransInnerDormDoubleRoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VM_TransInternationalDormTripleRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Ammon );
                FileImge2 = SaveImage(collection.File_Jerash);
                TransInternationalDormTripleRoom obj3 = new TransInternationalDormTripleRoom
                {
                    TransInternationalDormTripleRoomId = collection.TransInternationalDormTripleRoomId,
                    TransAmmonDormTripleRoomBrief = collection.TransAmmonDormTripleRoomBrief,
                    TransAmmonDormTripleRoomLinkUrl = collection.TransAmmonDormTripleRoomLinkUrl,
                    TransAmmonDormTripleRoomTitle = collection.TransAmmonDormTripleRoomTitle,
                    TransJarashDormTripleRoomTitle = collection.TransJarashDormTripleRoomTitle,
                    TransJerashDormTripleRoomBrief = collection.TransJerashDormTripleRoomBrief,
                    TransJerashDormTripleRoomLinkUrl = collection.TransJerashDormTripleRoomLinkUrl,



                    IsActive = true,
                    IsDelete = false,

                    MasterDormId = collection.MasterDormId,
                    TransAmmonDormTripleRoomImage = FileImge1,
                    TransJerashDormTripleRoomImage = FileImge2,
                };
                TransInternationalDormTripleRoom.Add(obj3);
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
            var data = TransInternationalDormTripleRoom.Find(id);
            VM_TransInternationalDormTripleRoom obj4 = new VM_TransInternationalDormTripleRoom();
            obj4.TransInternationalDormTripleRoomId = data.TransInternationalDormTripleRoomId;
            obj4.TransJarashDormTripleRoomTitle = data.TransJarashDormTripleRoomTitle;
            obj4.TransJerashDormTripleRoomBrief = data.TransJerashDormTripleRoomBrief;
            obj4.TransJerashDormTripleRoomLinkUrl = data.TransJerashDormTripleRoomLinkUrl;
            obj4.TransJerashDormTripleRoomImage = data.TransJerashDormTripleRoomImage;
            obj4.TransAmmonDormTripleRoomTitle = data.TransAmmonDormTripleRoomTitle;
            obj4.TransAmmonDormTripleRoomLinkUrl = data.TransAmmonDormTripleRoomLinkUrl;
            obj4.TransAmmonDormTripleRoomImage = data.TransAmmonDormTripleRoomImage;
            obj4.TransAmmonDormTripleRoomBrief = data.TransAmmonDormTripleRoomBrief;

            obj4.ListMasterDorm = MasterDorm.View();

            obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);

            //ViewBag.AA = MasterDorm.View();
          
            return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VM_TransInternationalDormTripleRoom collection)
        {
            try
            {
                string FileImge1 = "";
                string FileImge2 = "";


                FileImge1 = SaveImage(collection.File_Ammon);
                FileImge2 = SaveImage(collection.File_Jerash);
                TransInternationalDormTripleRoom obj5 = new TransInternationalDormTripleRoom
                {
                    TransInternationalDormTripleRoomId = collection.TransInternationalDormTripleRoomId,
                    TransAmmonDormTripleRoomBrief = collection.TransAmmonDormTripleRoomBrief,
                    TransAmmonDormTripleRoomLinkUrl = collection.TransAmmonDormTripleRoomLinkUrl,
                    TransAmmonDormTripleRoomTitle = collection.TransAmmonDormTripleRoomTitle,
                    TransJarashDormTripleRoomTitle = collection.TransJarashDormTripleRoomTitle,
                    TransJerashDormTripleRoomBrief = collection.TransJerashDormTripleRoomBrief,
                    TransJerashDormTripleRoomLinkUrl = collection.TransJerashDormTripleRoomLinkUrl,
                    IsActive = true,
                    IsDelete = false,

                    MasterDorm = MasterDorm.Find(collection.MasterDormId),
                    TransAmmonDormTripleRoomImage = (FileImge1 == "" ? collection.TransAmmonDormTripleRoomImage : FileImge1),
                    TransJerashDormTripleRoomImage = (FileImge2 == "" ? collection.TransJerashDormTripleRoomImage : FileImge2),

                };
                TransInternationalDormTripleRoom.Update(id, obj5);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransInnerDormDoubleRoomController/Delete/5
        public ActionResult Delete(int id, TransInternationalDormTripleRoom collection)
        {
            var data = TransInternationalDormTripleRoom.Find(id);
            data.IsDelete = true;
            TransInternationalDormTripleRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
            //var data = TransInternationalDormTripleRoom.Find(id);
            //VM_TransInternationalDormTripleRoom obj4 = new VM_TransInternationalDormTripleRoom();
            //obj4.TransInternationalDormTripleRoomId = data.TransInternationalDormTripleRoomId;
            //obj4.TransJarashDormTripleRoomTitle = data.TransJarashDormTripleRoomTitle;
            //obj4.TransJerashDormTripleRoomBrief = data.TransJerashDormTripleRoomBrief;
            //obj4.TransJerashDormTripleRoomLinkUrl = data.TransJerashDormTripleRoomLinkUrl;
            //obj4.TransJerashDormTripleRoomImage = data.TransJerashDormTripleRoomImage;
            //obj4.TransAmmonDormTripleRoomTitle = data.TransAmmonDormTripleRoomTitle;
            //obj4.TransAmmonDormTripleRoomLinkUrl = data.TransAmmonDormTripleRoomLinkUrl;
            //obj4.TransAmmonDormTripleRoomImage = data.TransAmmonDormTripleRoomImage;
            //obj4.TransAmmonDormTripleRoomBrief = data.TransAmmonDormTripleRoomBrief;
            //obj4.MasterDorm = MasterDorm.Find(data.MasterDormId);

            //ViewBag.AA = MasterDorm.View();

            //return View(obj4);
        }

        // POST: TransInnerDormDoubleRoomController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, TransInternationalDormTripleRoom collection)
        //{
        //    try
        //    {
        //        var data = TransInternationalDormTripleRoom.Find(id);
        //        data.IsDelete = true;
        //        TransInternationalDormTripleRoom.Update(id, data);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Active(int id)
        {
            var data = TransInternationalDormTripleRoom.Find(id);
            if (data.IsActive == true)
            {
                data.IsActive = false;

            }
            else
            {
                data.IsActive = true;
            }

            TransInternationalDormTripleRoom.Update(id, data);
            return RedirectToAction(nameof(Index));
        }
        string SaveImage(IFormFile File)
        {
            string FileImge = "";
            if (File != null)
            {
                Guid obj = Guid.NewGuid();

                string FilePath = Path.Combine(Hosting.WebRootPath, "WebImages/TransInternationalDormTripleRoom");
                FileInfo f = new FileInfo(File.FileName);
                FileImge = "WebImages" + obj + DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace("-", "") + f.Extension;
                string FullPath = Path.Combine(FilePath, FileImge);
                File.CopyTo(new FileStream(FullPath, FileMode.Create));
            }
            return FileImge;
        }
    }
}
