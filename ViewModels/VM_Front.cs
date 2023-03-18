using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemWebDorms.Models;

namespace SystemWebDorms.ViewModels
{
    public class VM_Front
    {
        public SystemSetting SystemSetting { get; set; }
        public List<MasterMenu> ListMasterMenu { get; set; }
        public List<MasterSlider> ListMasterSlider { get; set; }
        public List<MasterDorm> ListMasterDorm { get; set; }
        public List<MasterSocialMedium> ListMasterSocialMedium { get; set; }


        public List<TransInnerDormDoubleRoom> ListTransInnerDormDoubleRoom { get; set; }
        public List<TransInnerDormNight> ListTransInnerDormNight { get; set; }
        public List<TransInnerDormTripleRoom> ListTransInnerDormTripleRoom { get; set; }


        public List<TransInternationalDormDoubleRoom> ListTransInternationalDormDoubleRoom { get; set; }
        public List<TransInternationalDormDoubleRoomSister> ListTransInternationalDormDoubleRoomSister { get; set; }
        public List<TransInternationalDormNightRoom> ListTransInternationalDormNightRoom { get; set; }
        public List<TransInternationalDormSingleRoom> ListTransInternationalDormSingleRoom { get; set; }
        public List<TransInternationalDormTripleRoom> ListTransInternationalDormTripleRoom { get; set; }


        public TransContactUs TransContactUs { get; set; }

    }
}
