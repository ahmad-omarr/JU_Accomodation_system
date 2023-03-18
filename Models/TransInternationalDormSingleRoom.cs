using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class TransInternationalDormSingleRoom
    {
        public int TransInternationalDormSingleRoomId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Jarash Title")]
        public string TransJarashDormSingleRoomTitle { get; set; }
        [DisplayName("Jarash Brief")]
        public string TransJerashDormSingleRoomBrief { get; set; }
        [DisplayName("Jarash Image")]
        public string TransJerashDormSingleRoomImage { get; set; }
        [DisplayName("Jarash LinkUrl")]
        public string TransJerashDormSingleRoomLinkUrl { get; set; }
        [DisplayName("Ammon Title")]
        public string TransAmmonDormSingleRoomTitle { get; set; }
        [DisplayName("Ammon Brief")]
        public string TransAmmonDormSingleRoomBrief { get; set; }
        [DisplayName("Ammon Image")]
        public string TransAmmonDormSingleRoomImage { get; set; }
        [DisplayName("Ammon LinkUrl")]
        public string TransAmmonDormSingleRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }
    }
}
