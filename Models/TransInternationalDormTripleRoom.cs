using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class TransInternationalDormTripleRoom
    {
        public int TransInternationalDormTripleRoomId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Jarash  Title")]
        public string TransJarashDormTripleRoomTitle { get; set; }
        [DisplayName("Jarash  Brief")]
        public string TransJerashDormTripleRoomBrief { get; set; }
        [DisplayName("Jarash  Image")]
        public string TransJerashDormTripleRoomImage { get; set; }
        [DisplayName("Jarash  LinkUrl")]
        public string TransJerashDormTripleRoomLinkUrl { get; set; }
        [DisplayName("Ammon  Title")]
        public string TransAmmonDormTripleRoomTitle { get; set; }
        [DisplayName("Ammon  Brief")]
        public string TransAmmonDormTripleRoomBrief { get; set; }
        [DisplayName("Ammon  Image")]
        public string TransAmmonDormTripleRoomImage { get; set; }
        [DisplayName("Ammon  LinkUrl")]
        public string TransAmmonDormTripleRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }
    }
}
