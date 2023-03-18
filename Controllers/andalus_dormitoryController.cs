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
    public class andalus_dormitoryController : Controller
    {
        public InterfaceSystemWebDorms<SystemSetting> SystemSetting { get; }
        public InterfaceSystemWebDorms<MasterSocialMedium> ListMasterSocialMedium { get; }
        public InterfaceSystemWebDorms<MasterMenu> ListMasterMenu { get; }
        public InterfaceSystemWebDorms<TransInnerDormDoubleRoom> ListTransInnerDormDoubleRoom { get; }
        public InterfaceSystemWebDorms<TransInnerDormNight> ListTransInnerDormNight { get; }
        public InterfaceSystemWebDorms<TransInnerDormTripleRoom> ListTransInnerDormTripleRoom { get; }

        public andalus_dormitoryController(InterfaceSystemWebDorms<TransInnerDormDoubleRoom> _ListTransInnerDormDoubleRoom,
            InterfaceSystemWebDorms<TransInnerDormNight> _ListTransInnerDormNight,
            InterfaceSystemWebDorms<TransInnerDormTripleRoom> _ListTransInnerDormTripleRoom,
            InterfaceSystemWebDorms<SystemSetting> _SystemSetting,
            InterfaceSystemWebDorms<MasterSocialMedium> _ListMasterSocialMedium,
        InterfaceSystemWebDorms<MasterMenu> _ListMasterMenu)
        {
            ListTransInnerDormDoubleRoom = _ListTransInnerDormDoubleRoom;
            ListTransInnerDormNight = _ListTransInnerDormNight;
            ListTransInnerDormTripleRoom = _ListTransInnerDormTripleRoom;
            SystemSetting = _SystemSetting;
            ListMasterSocialMedium = _ListMasterSocialMedium;
            ListMasterMenu = _ListMasterMenu;
        }



        public IActionResult Index()
        {
            //VM_InnerDorm obj = new VM_InnerDorm
            VM_Front obj = new VM_Front

            {
                ListTransInnerDormDoubleRoom = ListTransInnerDormDoubleRoom.ViewClient(),
                ListTransInnerDormNight = ListTransInnerDormNight.ViewClient(),
                ListTransInnerDormTripleRoom = ListTransInnerDormTripleRoom.ViewClient(),
                ListMasterSocialMedium = ListMasterSocialMedium.ViewClient(),
                SystemSetting = SystemSetting.ViewClient().OrderByDescending(x => x.SystemSettingId).FirstOrDefault(),
                ListMasterMenu = ListMasterMenu.ViewClient(),

            };


            return View(obj);
        }
    }
}