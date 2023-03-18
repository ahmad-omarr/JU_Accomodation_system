using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class TransInternationalDormDoubleRoomSister
    {
        public int TransInternationalDormDoubleRoomSisterId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Jarash Title")]
        public string TransJarashDormDoubleRoomSistersTitle { get; set; }
        [DisplayName("Jarash Brief")]
        public string TransJerashDormDoubleRoomSistersBrief { get; set; }
        [DisplayName("Jarash Image")]
        public string TransJerashDormDoubleRoomSistersImage { get; set; }
        [DisplayName("Jarash LinkUrl")]
        public string TransJerashDormDoubleRoomSistersLinkUrl { get; set; }
        [DisplayName("Ammon Title")]
        public string TransAmmonDormDoubleRoomSistersTitle { get; set; }
        [DisplayName("Ammon Brief")]
        public string TransAmmonDormDoubleRoomSistersBrief { get; set; }
        [DisplayName("Ammon Image")]
        public string TransAmmonDormDoubleRoomSistersImage { get; set; }
        [DisplayName("Ammon LinkUrl")]
        public string TransAmmonDormDoubleRoomSistersLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }
    }
}
