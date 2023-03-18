using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class TransInternationalDormDoubleRoom
    {
        public int TransInternationalDormDoubleRoomId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Jarash Title")]
        public string TransJarashDormDoubleRoomTitle { get; set; }
        [DisplayName("Jarash Brief")]
        public string TransJerashDormDoubleRoomBrief { get; set; }
        [DisplayName("Jarash Image")]
        public string TransJerashDormDoubleRoomImage { get; set; }
        [DisplayName("Jarash LinkUrl")]
        public string TransJerashDormDoubleRoomLinkUrl { get; set; }
        [DisplayName("Ammon Title")]
        public string TransAmmonDormDoubleRoomTitle { get; set; }
        [DisplayName("Ammon Brief")]
        public string TransAmmonDormDoubleRoomBrief { get; set; }
        [DisplayName("Ammon Image")]
        public string TransAmmonDormDoubleRoomImage { get; set; }
        [DisplayName("Ammon LinkUrl")]
        public string TransAmmonDormDoubleRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }
    }
}
