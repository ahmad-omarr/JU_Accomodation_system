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
    public class ammon_dormitoryController : Controller
    {
        public InterfaceSystemWebDorms<SystemSetting> SystemSetting { get; }
        public InterfaceSystemWebDorms<MasterSocialMedium> ListMasterSocialMedium { get; }
        public InterfaceSystemWebDorms<MasterMenu> ListMasterMenu { get; }
        public InterfaceSystemWebDorms<TransInternationalDormDoubleRoom> ListTransInternationalDormDoubleRoom { get; }
        public InterfaceSystemWebDorms<TransInternationalDormDoubleRoomSister> ListTransInternationalDormDoubleRoomSister { get; }
        public InterfaceSystemWebDorms<TransInternationalDormNightRoom> ListTransInternationalDormNightRoom { get; }
        public InterfaceSystemWebDorms<TransInternationalDormSingleRoom> ListTransInternationalDormSingleRoom { get; }
        public InterfaceSystemWebDorms<TransInternationalDormTripleRoom> ListTransInternationalDormTripleRoom { get; }

        public ammon_dormitoryController(InterfaceSystemWebDorms<SystemSetting> _SystemSetting,
            InterfaceSystemWebDorms<MasterSocialMedium> _ListMasterSocialMedium,
        InterfaceSystemWebDorms<MasterMenu> _ListMasterMenu,
        InterfaceSystemWebDorms<TransInternationalDormDoubleRoom> _ListTransInternationalDormDoubleRoom,
        InterfaceSystemWebDorms<TransInternationalDormDoubleRoomSister> _ListTransInternationalDormDoubleRoomSister,
        InterfaceSystemWebDorms<TransInternationalDormNightRoom> _ListTransInternationalDormNightRoom,
        InterfaceSystemWebDorms<TransInternationalDormSingleRoom> _ListTransInternationalDormSingleRoom,
        InterfaceSystemWebDorms<TransInternationalDormTripleRoom> _ListTransInternationalDormTripleRoom)
        {
            SystemSetting = _SystemSetting;
            ListMasterSocialMedium = _ListMasterSocialMedium;
            ListMasterMenu = _ListMasterMenu;
            ListTransInternationalDormDoubleRoom = _ListTransInternationalDormDoubleRoom;
            ListTransInternationalDormDoubleRoomSister = _ListTransInternationalDormDoubleRoomSister;
            ListTransInternationalDormNightRoom = _ListTransInternationalDormNightRoom;
            ListTransInternationalDormSingleRoom = _ListTransInternationalDormSingleRoom;
            ListTransInternationalDormTripleRoom = _ListTransInternationalDormTripleRoom;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            VM_Front obj = new VM_Front
            {
                ListMasterSocialMedium = ListMasterSocialMedium.ViewClient(),
                SystemSetting = SystemSetting.ViewClient().OrderByDescending(x => x.SystemSettingId).FirstOrDefault(),
                ListMasterMenu = ListMasterMenu.ViewClient(),
                ListTransInternationalDormDoubleRoom = ListTransInternationalDormDoubleRoom.ViewClient(),
                ListTransInternationalDormDoubleRoomSister = ListTransInternationalDormDoubleRoomSister.ViewClient(),
                ListTransInternationalDormNightRoom = ListTransInternationalDormNightRoom.ViewClient(),
                ListTransInternationalDormSingleRoom = ListTransInternationalDormSingleRoom.ViewClient(),
                ListTransInternationalDormTripleRoom = ListTransInternationalDormTripleRoom.ViewClient(),

            };
            return View(obj);
        }
    }
}
