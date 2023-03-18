using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class TransInternationalDormNightRoom
    {
        public int TransInternationalDormNightRoomId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Jarash Title")]
        public string TransJarashDormNightRoomTitle { get; set; }
        [DisplayName("Jarash Brief")]
        public string TransJerashDormNightRoomBrief { get; set; }
        [DisplayName("Jarash Image")]
        public string TransJerashDormNightRoomImage { get; set; }
        [DisplayName("Jarash LinkUrl")]
        public string TransJerashDormNightRoomLinkUrl { get; set; }
        [DisplayName("Ammon Title")]
        public string TransAmmonDormNightRoomTitle { get; set; }
        [DisplayName("Ammon Brief")]
        public string TransAmmonDormNightRoomBrief { get; set; }
        [DisplayName("Ammon Image")]
        public string TransAmmonDormNightRoomImage { get; set; }
        [DisplayName("Ammon LinkUrl")]
        public string TransAmmonDormNightRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }
    }
}
